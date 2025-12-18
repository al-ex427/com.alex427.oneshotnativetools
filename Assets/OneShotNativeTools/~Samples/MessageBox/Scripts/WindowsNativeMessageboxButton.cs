using OneShot.NativeTools;
using UnityEngine;

namespace OneShot.NativeTools.Examples.Example1
{
public class WindowsNativeMessageboxButton : MonoBehaviour
{
    [SerializeField] private string message = "Sample text";
    [SerializeField] private string caption = "Sample caption";

    public void Trigger()
    {
        OneShotNativeToolsManager.Instance.Windows_NativeMessageBox(message,caption);
    }
}
}