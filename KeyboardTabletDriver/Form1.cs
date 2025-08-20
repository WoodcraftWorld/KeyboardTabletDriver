using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace KeyboardTabletDriver
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
        public static int MapValue(int x, int a1, int a2, int b1, int b2)
        {
            return b1 + ((x - a1) * (b2 - b1)) / (a2 - a1);
        }

        public int[] KeyToMousePosition(string KeyPress)
        {
            int WidthOfKeyboardPicture = 406;
            int HeightOfKeyboardPicture = 144;
            int x = 0;
            int y = 0;
            switch (KeyPress) 
            {
                case "Oem8":
                    x = 15;
                    y = 15;
                    break;
                case "D1":
                    x = 42;
                    y = 15;
                    break;
                case "D2":
                    x = 66;
                    y = 15;
                    break;
                case "D3":
                    x = 94; y = 16; break;
                case "D4":
                    x = 120; y = 16; break;
                case "D5":
                    x = 149; y = 15; break;
                case "D6":
                    x = 172; y = 17; break;
                case "D7":
                    x = 199; y = 17; break;
                case "D8":
                    x = 225; y = 18; break;
                case "D9":
                    x = 251; y = 15; break;
                case "D0":
                    x = 278; y = 18; break;
                case "OemMinus":
                    x = 304; y = 12; break;
                case "Oemplus":
                    x = 329; y = 15; break;
                case "Back":
                    x = 371; y = 17; break;
                case "Tab":
                    x = 23; y = 44; break;
                case "Q":
                    x = 55; y = 44; break;
                case "W":
                    x = 84; y = 42; break;
                case "E":
                    x = 108; y = 43; break;
                case "R":
                    x = 133; y = 44; break;
                case "T":
                    x = 164; y = 41; break;
                case "Y":
                    x = 187; y = 43; break;
                case "U":
                    x = 212; y = 44; break;
                case "I":
                    x = 240; y = 42; break;
                case "O":
                    x = 264; y = 44; break;
                case "P":
                    x = 291; y = 42; break;
                case "Oem4":
                    x = 317; y = 43; break;
                case "Oem6":
                    x = 342; y = 44; break;
                case "Enter":
                    x = 380; y = 56; break;
                case "Capital":
                    x = 25; y = 69; break;
                case "A":
                    x = 61; y = 70; break;
                case "S":
                    x = 88; y = 69; break;
                case "D":
                    x = 114; y = 70; break;
                case "F":
                    x = 140; y = 70; break;
                case "G":
                    x = 166; y = 69; break;
                case "H":
                    x = 194; y = 69; break;
                case "J":
                    x = 222; y = 67; break;
                case "K":
                    x = 245; y = 67; break;
                case "L":
                    x = 271; y = 68; break;
                case "OemSemicolon":
                    x = 297; y = 67; break;
                case "Oem3":
                    x = 324; y = 70; break;
                case "Oem7":
                    x = 350; y = 69; break;
                case "LShiftKey":
                    x = 20; y = 94; break;
                case "OemPipe":
                    x = 48; y = 94; break;
                case "Z":
                    x = 76; y = 95; break;
                case "X":
                    x = 101; y = 94; break;
                case "C":
                    x = 126; y = 95; break;
                case "V":
                    x = 154; y = 94; break;
                case "B":
                    x = 181; y = 97; break;
                case "N":
                    x = 207; y = 94; break;
                case "M":
                    x = 233; y = 94; break;
                case "Oemcomma":
                    x = 259; y = 96; break;
                case "OemPeriod":
                    x = 287; y = 95; break;
                case "Oem2":
                    x = 310; y = 94; break;
                case "RShiftKey":
                    x = 348; y = 95; break;
                case "Up":
                    x = 390; y = 101; break;
                case "LControlKey":
                    x = 19; y = 122; break;
                case "lalt":
                    x = 82; y = 123; break;
                case "Space":
                    x = 181; y = 121; break;
                case "RControlKey":
                    x = 332; y = 122; break;
                case "Left":
                    x = 363; y = 127; break;
                case "Down":
                    x = 390; y = 129; break;
            }
            return [Convert.ToInt32(PositionX.Value)+MapValue(x,0,WidthOfKeyboardPicture,Convert.ToInt32(PositionX.Value),Convert.ToInt32(AreaWidth.Value)), Convert.ToInt32(PositionY.Value)+MapValue(y, 0, HeightOfKeyboardPicture, Convert.ToInt32(PositionY.Value), Convert.ToInt32(AreaHeight.Value))];
        }
        private GlobalKeyboardHook gHook;
        public Form1()
        {
            InitializeComponent();
            gHook = new GlobalKeyboardHook();
            gHook.KeyPressed += GHook_KeyPressed;
        }
        private void GHook_KeyPressed(object sender, KeyEventArgs e)
    {
            if (checkBox1.Checked)
            {
                label5.Text = $"{e.KeyCode}";
                SetCursorPos(KeyToMousePosition($"{e.KeyCode}")[0], KeyToMousePosition($"{e.KeyCode}")[1]);
            } else
            {
                label5.Text = "Not activated";
            }
    }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AreaWidth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    public class GlobalKeyboardHook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;

        private IntPtr hookId = IntPtr.Zero;
        private LowLevelKeyboardProc proc;

        public event KeyEventHandler KeyPressed;

        public GlobalKeyboardHook()
        {
            proc = HookCallback;
            hookId = SetHook(proc);
        }

        ~GlobalKeyboardHook()
        {
            UnhookWindowsHookEx(hookId);
        }

        private IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                Keys key = (Keys)vkCode;
                KeyPressed?.Invoke(this, new KeyEventArgs(key));
            }
            return CallNextHookEx(hookId, nCode, wParam, lParam);
        }

       
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll")]
        private static extern IntPtr CallNextHookEx(IntPtr hhk,
            int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }

}
