using System;
using System.Runtime.InteropServices;

namespace OneShot.NativeTools
{
    public static class WindowUtil
    {
        #if UNITY_STANDALONE_OSX
        [DllImport("liboneshot-3d-nativetools", CharSet = CharSet.Ansi)]
        private static extern void SetTitle(string title);
        #elif UNITY_STANDALONE_WIN
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowTextW(IntPtr hWnd, string lpString);
        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();
        
        private static void SetTitle(string title) {
            SetWindowTextW(GetActiveWindow(), title);
        }
#endif


        public static void SetWindowTitle(string title)
        {
            SetTitle(title);
        }
    }
}