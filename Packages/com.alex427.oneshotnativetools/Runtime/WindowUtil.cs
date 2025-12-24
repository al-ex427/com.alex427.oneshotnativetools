using System;
using System.Runtime.InteropServices;

namespace OneShot.NativeTools
{
    public static class WindowUtil
    {
        #if UNITY_STANDALONE_OSX
        [DllImport("liboneshot-3d-nativetools", CharSet = CharSet.Ansi)]
        private static extern bool SetTitle(string title);
        #elif UNITY_STANDALONE_WIN
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern bool SetWindowTextW(IntPtr hWnd, string lpString);
        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();
        
        private static bool SetTitle(string title) {
           return SetWindowTextW(GetActiveWindow(), title);
        }
#endif


        public static bool SetWindowTitle(string title)
        {
            return SetTitle(title);
        }
    }
}