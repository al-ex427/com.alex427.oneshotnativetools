using System;
using System.Runtime.InteropServices;
#if UNITY_STANDALONE_WIN
using OneShot.NativeTools.Windows;
#endif
using UnityEngine;

namespace OneShot.NativeTools
{
    [Serializable]
    public class MessageBoxClass : IDisposable
    {

        public bool gotResult => result != null;
        
        public string result { get; private set; }

        MessageBoxClass(string caption, string text)
        {
            
        }
        public void Dispose()
        {
            
        }
    }
}