using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using OneShot.NativeTools.Windows;
using UnityEngine;

namespace OneShot.NativeTools
{
    public sealed class OneShotNativeToolsManager : MonoBehaviour
    {

        #region Assets/Scripts/OneShot/Singleton.cs

        private static OneShotNativeToolsManager? _instance;

        public static OneShotNativeToolsManager Instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = FindAnyObjectByType<OneShotNativeToolsManager>();
                    if (!_instance)
                    {
                        GameObject obj = new GameObject { name = "MessageBoxTool"};
                        _instance = obj.AddComponent<OneShotNativeToolsManager>();
                    }
                }

                return _instance;
            }
            
        }
        
        private void Awake()
        {
            if (_instance != null && _instance != this)
            {
                Destroy(gameObject);
            } else {
                _instance = this;
                if (transform.parent == null) DontDestroyOnLoad(gameObject);
            }

        }
        #endregion

        #region Message Boxes

        

        
        public void TriggerMessageBox(string message, string caption)
        {
            
        }
        
        #if UNITY_STANDALONE_WIN

        #region STATIC EXPORTS

        [DllImport("user32.dll")]
        private static extern IntPtr GetActiveWindow();
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern int MessageBox(IntPtr hWnd, string text, string caption, uint uType);
        
        #endregion
        
        /// <summary>
        /// Use the Windows native messagebox instead of TaskDialog<br/>
        /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messagebox">See Microsoft Docs</a>
        /// </summary>
        public Task<MessageBoxResult> Windows_NativeMessageBox(string message, string caption, uint type = 0x0, bool waitForResponse = true)
        {

            MessageBoxResult? msgBox = null;
            Task.Run(() =>
            {
                msgBox = (MessageBoxResult)MessageBox(GetActiveWindow(), message, caption, type);
            });

            if (waitForResponse)
            {
                while (msgBox == null)
                {
                    Task.Delay(1);
                }
            }

            Debug.Log("triggered");
            return Task.FromResult(msgBox ?? default(MessageBoxResult));
        }
        #endif
        
        
        #endregion

        #region User names

        public string GetSystemUser()
        {
            #if !UNITY_ANDROID && !UNITY_IOS
                return Environment.UserName;
            #else 
                return "User";
            #endif
            
            
        }

        #endregion

    }
}