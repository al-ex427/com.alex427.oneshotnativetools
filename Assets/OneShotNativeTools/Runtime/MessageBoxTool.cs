using System;
using System.Threading.Tasks;
using OneShot.NativeTools.Windows;
using UnityEngine;

namespace OneShot.NativeTools
{
    public sealed class MessageBoxTool : MonoBehaviour
    {

        #region Assets/Scripts/OneShot/Singleton.cs

        private static MessageBoxTool _instance;

        public static MessageBoxTool Instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = FindAnyObjectByType<MessageBoxTool>();
                    if (!_instance)
                    {
                        GameObject obj = new GameObject { name = "MessageBoxTool"};
                        _instance = obj.AddComponent<MessageBoxTool>();
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

        public void TriggerMessageBox(string message, string caption)
        {
            
        }
        
        #if UNITY_STANDALONE_WIN
        public Task<MessageBoxResult> Windows_NativeMessageBox(string message, string caption)
        {

            while (!msgBox.gotResult)
            {
                Task.Yield();
            }
            return Task.FromResult(msgBox);
        }
        #endif

    }
}