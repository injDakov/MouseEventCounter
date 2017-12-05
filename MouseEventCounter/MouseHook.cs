using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace MouseEventCounter
{
    public static class MouseHook
    {
        public static event EventHandler MouseActionMove = delegate { };

        public static event EventHandler MouseActionLeftCick = delegate { };

        public static event EventHandler MouseActionMiddleCick = delegate { };

        public static event EventHandler MouseActionRightCick = delegate { };

        public static event EventHandler MouseActionWheel = delegate { };

        public static void Start()
        {
            _hookID = SetHook(_proc);
        }

        public static void Stop()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                    GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam)
            {
                MouseActionMove(null, new EventArgs());
            }
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MouseActionLeftCick(null, new EventArgs());
            }

            if (nCode >= 0 && MouseMessages.WM_MBUTTONDOWNP == (MouseMessages)wParam)
            {
                MouseActionMiddleCick(null, new EventArgs());
            }

            if (nCode >= 0 && MouseMessages.WM_RBUTTONDOWN == (MouseMessages)wParam)
            {
                MouseActionRightCick(null, new EventArgs());
            }

            if (nCode >= 0 && MouseMessages.WM_MOUSEWHEEL == (MouseMessages)wParam)
            {
                MouseActionWheel(null, new EventArgs());
            }

            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,

            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,

            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205,

            WM_MBUTTONDOWNP = 0x0207
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}