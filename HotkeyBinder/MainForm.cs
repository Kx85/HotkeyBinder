using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotkeyBinder
{
    public partial class MainForm : Form
    {
        private String filepath;
        private Default defaultValues;
        private static readonly List<Keys> allKeys = Enum.GetValues(typeof(Keys)).Cast<Keys>().ToList();

        public MainForm()
        {
            InitializeComponent();
            defaultValues = new Default();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetKeybindsView();
        }

        private void DefaultInputButton_Click(object sender, EventArgs e)
        {
            ResetKeybindsView();
            uploadedInputFilePath.Clear();
        }

        private void UploadInputFileButton_Click(object sender, EventArgs e)
        {

            // Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".*"; // Default file extension
            dlg.Filter = "All Files |*.*"; // Filter files by extension

            // Show open file dialog box
            DialogResult result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == DialogResult.OK)
            {
                // Open document
                filepath = dlg.FileName;
                uploadedInputFilePath.Text = filepath;
                UpdateKeybindingsFromFile(filepath);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.DefaultExt = ".ini";
            dlg.Filter = "Configuration File |*.ini";

            DialogResult result = dlg.ShowDialog();

            if (result == DialogResult.OK)
            {
                filepath = dlg.FileName;
                uploadedInputFilePath.Text = filepath;
                SaveKeybindingsToFile(filepath);
            }
        }

        private void ResetKeybind_Click(object sender, EventArgs e)
        {
            if (keybinds.SelectedRows.Count == 1)
            {
                var index = keybinds.SelectedRows[0].Index;
                var defaultItem = defaultValues.GetDefaultKeybindFor(keybinds.Rows[keybinds.SelectedRows[0].Index].Cells[0].Value.ToString());
                keybinds.Rows.RemoveAt(index);
                keybinds.Rows.Insert(index, CreateRow(defaultItem));
                keybinds.Rows[index].Selected = true;
            }
        }

        private void ResetKeybindsView()
        {
            UpdateKeybindings(defaultValues.getDefaultKeybinds());
        }

        private void UpdateKeybindingsFromFile(string filepath)
        {
            UpdateKeybindings(FileReader.ReadFromFile(filepath));
        }

        private void SaveKeybindingsToFile(String filepath)
        {
            FileSaver.SaveFileToDisk(filepath, ToItems(keybinds.Rows));
        }

        private List<Item> ToItems(DataGridViewRowCollection rows)
        {
            return rows.Cast<DataGridViewRow>()
                            .Select(row =>
                            new Item(
                                row.Cells[0].Value.ToString(),
                                (Keys)row.Cells[1].Value,
                                (bool)row.Cells[2].Value,
                                (bool)row.Cells[3].Value,
                                (bool)row.Cells[4].Value,
                                (bool)row.Cells[5].Value
                            ))
                            .ToList();
        }

        private void UpdateKeybindings(List<Item> items)
        {
            keybinds.Rows.Clear();
            keybinds.ClearSelection();
            keybinds.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            keybinds.MultiSelect = false;

            items.ForEach(item =>
            {
                DataGridViewRow row = CreateRow(item);
                keybinds.Rows.Add(row);
            });
        }

        private static DataGridViewRow CreateRow(Item item)
        {
            DataGridViewRow row = new DataGridViewRow();
            var test = new DataGridViewComboBoxCell();
            test.DataSource = allKeys;
            test.Value = allKeys.IndexOf(item.getKey());
            row.Cells.Add(new DataGridViewTextBoxCell() { Value = item.getAction() });
            row.Cells.Add(new DataGridViewComboBoxCell() { DataSource = allKeys, Value = item.getKey() });
            row.Cells.Add(new DataGridViewCheckBoxCell() { Value = item.getShiftModifier() });
            row.Cells.Add(new DataGridViewCheckBoxCell() { Value = item.getCtrlModifier() });
            row.Cells.Add(new DataGridViewCheckBoxCell() { Value = item.getAltModifier() });
            row.Cells.Add(new DataGridViewCheckBoxCell() { Value = item.getCmdModifier() });
            return row;
        }

        private void Keybinds_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            bool validClick = (e.RowIndex != -1 && e.ColumnIndex != -1); //Make sure the clicked row/column is valid.
            var datagridview = sender as DataGridView;

            // Check to make sure the cell clicked is the cell containing the combobox 
            if (datagridview.Columns[e.ColumnIndex] is DataGridViewComboBoxColumn && validClick)
            {
                datagridview.BeginEdit(true);
                ((ComboBox)datagridview.EditingControl).DroppedDown = true;
            }
        }
    }
}
