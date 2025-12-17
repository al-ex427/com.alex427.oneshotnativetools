using OneShot.NativeTools.Windows;
using UnityEngine;

namespace OneShot.NativeTools
{
    public class MessageBoxClass : MonoBehaviour
    {
        public bool gotResult => result != null;
        
        #if UNITY_STANDALONE_WIN
        [field: SerializeField] public MessageBoxResult result{ get; private set; }
#endif
    }
}