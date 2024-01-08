using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotkeyBinder
{
    public class Default
    {
        private List<Item> defaultList;

        public Default()
        {
            defaultList = new List<Item>
            {
                new Item("Ability1", Keys.Q),
                new Item("Ability2", Keys.W),
                new Item("Ability3", Keys.E),
                new Item("Ability4", Keys.R),
                new Item("Ability5", Keys.F),
                new Item("Ability6", Keys.Tab),
                new Item("Ability7", Keys.A),
                new Item("Ability8", Keys.S),
                new Item("AttackMove", Keys.A),
                new Item("CancelOrders", Keys.Tilde),
                new Item("CompleteAllTraining", Keys.I),
                new Item("CompleteConstructions", Keys.K),
                new Item("ConstructionTab", Keys.C),
                new Item("ControlGroup1", Keys.D),
                new Item("ControlGroup2", Keys.One),
                new Item("ControlGroup3", Keys.Two),
                new Item("ControlGroup4", Keys.Three),
                new Item("ControlGroup5", Keys.Four),
                new Item("ControlGroup6", Keys.Five),
                new Item("ControlGroup7", Keys.Six),
                new Item("ControlGroup8", Keys.Seven),
                new Item("ControlGroup9", Keys.Eight),
                new Item("ControlGroup10", Keys.Nine),
                new Item("ControlGroup11", Keys.Zero),
                new Item("ControlGroupAddStealKey", Keys.SpaceBar),
                new Item("Delete", Keys.Delete),
                new Item("DisableWeapons", Keys.J, true, false, true, false),
                new Item("UpArrow", Keys.Up),
                new Item("DownArrow", Keys.Down),
                new Item("LeftArrow", Keys.Left),
                new Item("RightArrow", Keys.Right),
                new Item("DragPan", Keys.MiddleMouseButton),
                new Item("Enter Cinematic Camera", Keys.L, true, false, true, false),
                new Item("FullMana", Keys.J),
                new Item("FullyDamageSelectedUnits", Keys.P),
                new Item("GetAlloyEther", Keys.M),
                new Item("GetPyre", Keys.L),
                new Item("Hide HUD", Keys.O, true, false, true, false),
                new Item("InclusiveSelect/QueueCommand", Keys.LeftShift),
                new Item("JumpToCameraLocation1", Keys.Z, true, false, false, false),
                new Item("JumpToCameraLocation2", Keys.X, true, false, false, false),
                new Item("JumpToCameraLocation3", Keys.C, true, false, false, false),
                new Item("JumpToCameraLocation4", Keys.V, true, false, false, false),
                new Item("JumpToCameraLocation5", Keys.One, true, false, false, false),
                new Item("JumpToCameraLocation6", Keys.Two, true, false, false, false),
                new Item("JumpToCameraLocation7", Keys.Three, true, false, false, false),
                new Item("JumpToCameraLocation8", Keys.Four, true, false, false, false),
                new Item("LeftMouseClick", Keys.LeftMouseButton),
                new Item("MarcoPolo", Keys.Comma),
                new Item("Menu", Keys.Escape),
                new Item("MinimapJumpTo", Keys.LeftMouseButton),
                new Item("Move/ContextCommand", Keys.RightMouseButton),
                new Item("PyreTab", Keys.V),
                new Item("ResearchTab", Keys.X),
                new Item("RespawnNeutrals", Keys.N),
                new Item("RightMouseClick", Keys.RightMouseButton),
                new Item("Select/ConfirmAbility", Keys.LeftMouseButton),
                new Item("SelectUnitProductionBuildingsy", Keys.Z),
                new Item("SetCameraLocation1", Keys.Z, false, true, false, false),
                new Item("SetCameraLocation2", Keys.X, false, true, false, false),
                new Item("SetCameraLocation3", Keys.C, false, true, false, false),
                new Item("SetCameraLocation4", Keys.V, false, true, false, false),
                new Item("SetCameraLocation5", Keys.One, false, true, false, false),
                new Item("SetCameraLocation6", Keys.Two, false, true, false, false),
                new Item("SetCameraLocation7", Keys.Three, false, true, false, false),
                new Item("SetCameraLocation8", Keys.Four, false, true, false, false),
                new Item("SpectatorDisplayUI", Keys.W, false, false, true, false),
                new Item("SpectatorTeamOneVision", Keys.A, false, false, true, false),
                new Item("SpectatorTeamTwoVision", Keys.S, false, false, true, false),
                new Item("SpectatorAllTeamsVision", Keys.D, false, false, true, false),
                new Item("StandGround", Keys.S),
                new Item("SwitchAbilityCommandLayer", Keys.SpaceBar),
                new Item("TheCheatToRuleThemAll", Keys.None),
                new Item("Toggle Gamepad", Keys.Slash, false, true, true, false),
                new Item("UnitTypeSelectionModifier", Keys.LeftControl),
                new Item("ZoomIn", Keys.MouseScrollUp),
                new Item("ZoomOut", Keys.MouseScrollDown)
            };
        }

        public List<Item> getDefaultKeybinds()
        {
            return defaultList;
        }

        internal Item GetDefaultKeybindFor(string text)
        {
            return defaultList.Find(item => item.getAction().Equals(text));
        }
    }

    public class Item
    {
        private readonly String name;
        private readonly Keys value;
        private readonly Boolean bShift;
        private readonly Boolean bCtrl;
        private readonly Boolean bAlt;
        private readonly Boolean bCmd;

        public Item(String name, Keys value) : this(name, value, false, false, false, false) { }

        public Item(String name, Keys value, Boolean bShift, Boolean bCtrl, Boolean bAlt, Boolean bCmd)
        {
            this.name = name;
            this.value = value;
            this.bShift = bShift;
            this.bCtrl = bCtrl;
            this.bAlt = bAlt;
            this.bCmd = bCmd;
        }

        public String getAction()
        {
            return this.name;
        }

        public Keys getKey()
        {
            return this.value;
        }

        public Boolean getShiftModifier()
        {
            return this.bShift;
        }

        public Boolean getCtrlModifier()
        {
            return this.bCtrl;
        }

        public Boolean getAltModifier()
        {
            return this.bAlt;
        }

        public Boolean getCmdModifier()
        {
            return this.bCmd;
        }
    }
}
