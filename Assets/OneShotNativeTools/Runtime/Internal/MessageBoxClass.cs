using System;
using System.Runtime.InteropServices;
using OneShot.NativeTools.Windows;
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