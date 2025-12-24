using System;
using UnityEngine;

namespace OneShot.NativeTools
{
    public class NativeToolsManager : MonoBehaviour
    {
        
        #region SINGLETON

        private static NativeToolsManager _instance;

        public static NativeToolsManager Instance
        {
            get
            {
                
                if (!_instance)
                {
                    _instance = FindAnyObjectByType<NativeToolsManager>();
                    if (!_instance)
                    {
                        GameObject obj = new GameObject
                        {
                            name = typeof(NativeToolsManager).Name
                        };
                        _instance = obj.AddComponent<NativeToolsManager>();
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
            }
            else
            {
                _instance = this;
                if (transform.parent == null) DontDestroyOnLoad(gameObject);
            }

        }

        #endregion


        private void Start()
        {
            WindowUtil.TrySetWindow();
        }
    }
}