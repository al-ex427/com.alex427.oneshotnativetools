#if UNITY_STANDALONE_WIN
namespace OneShot.NativeTools.Ext.Windows
{
    
    /// <summary>
    /// what the messagebox returns in an enum, only used in native environments<br/>
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messagebox#return-value">See Microsoft Docs</a>
    /// </summary>
    public enum MessageBoxResult
    {
        OK = 1,
        CANCEL = 2,
        ABORT = 3,
        RETRY = 4,
        IGNORE = 5,
        YES = 6,
        NO = 7,
        TRYAGAIN = 10,
        CONTINUE = 11
    }
    
}
#endif