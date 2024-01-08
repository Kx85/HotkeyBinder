using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotkeyBinder
{
    public class KeyboardLayout
    {
        internal static Keys ToKey(string value)
        {
            throw new NotImplementedException();
        }
        public static bool ExistsKey(String value)
        {
            return true;
        }
    }


    public enum Keys
    {
        None,
        AnyKey,
        MouseX,
        MouseY,
        Mouse2D,
        MouseScrollUp,
        MouseScrollDown,
        MouseWheelAxis,

        LeftMouseButton,
        RightMouseButton,
        MiddleMouseButton,
        ThumbMouseButton,
        ThumbMouseButton2,

        BackSpace,
        Tab,
        Enter,
        Pause,

        CapsLock,
        Escape,
        SpaceBar,
        PageUp,
        PageDown,
        End,
        Home,

        Left,
        Up,
        Right,
        Down,

        Insert,
        Delete,

        Zero,
        One,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,

        A,
        B,
        C,
        D,
        E,
        F,
        G,
        H,
        I,
        J,
        K,
        L,
        M,
        N,
        O,
        P,
        Q,
        R,
        S,
        T,
        U,
        V,
        W,
        X,
        Y,
        Z,

        NumPadZero,
        NumPadOne,
        NumPadTwo,
        NumPadThree,
        NumPadFour,
        NumPadFive,
        NumPadSix,
        NumPadSeven,
        NumPadEight,
        NumPadNine,

        Multiply,
        Add,
        Subtract,
        Decimal,
        Divide,

        F1,
        F2,
        F3,
        F4,
        F5,
        F6,
        F7,
        F8,
        F9,
        F10,
        F11,
        F12,

        NumLock,

        ScrollLock,

        LeftShift,
        RightShift,
        LeftControl,
        RightControl,
        LeftAlt,
        RightAlt,
        LeftCommand,
        RightCommand,

        Semicolon,
        Equals,
        Comma,
        Underscore,
        Hyphen,
        Period,
        Slash,
        Tilde,
        LeftBracket,
        Backslash,
        RightBracket,
        Apostrophe,

        Ampersand,
        Asterix,
        Caret,
        Colon,
        Dollar,
        Exclamation,
        LeftParantheses,
        RightParantheses,
        Quote,

        A_AccentGrave,
        E_AccentGrave,
        E_AccentAigu,
        C_Cedille,
        Section
    }
}
