using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace OneShot.NativeTools
{
    public static class WindowUtil 
    {
        #region IMPORTS

        [DllImport("liboneshot-3d-nativetools", CharSet = CharSet.Auto)]
        private static extern bool SetTitle(string title);
        
        [DllImport("liboneshot-3d-nativetools", CharSet = CharSet.Auto)]
        public static extern bool TrySetWindow();

        #endregion


 

        public static bool SetWindowTitle(string title)
        {
            if (!NativeToolsManager.Instance) return false;
            if (!SetTitle(title))
            {
                Debug.LogError("<b>[ONESHOT NATIVE TOOLS]</b> : unable to change title, likely an error inside the dll");
                #if UNITY_STANDALONE_WIN || UNITY_STANDALONE_WIN
                Debug.Log($"<b>[ONESHOT NATIVE TOOLS / WIN32]</b> : follow up to the error; WIN32 api returned err code: {Marshal.GetLastWin32Error()}");
                #endif
                return false;
            }
            
            return true;
        }
    }
}