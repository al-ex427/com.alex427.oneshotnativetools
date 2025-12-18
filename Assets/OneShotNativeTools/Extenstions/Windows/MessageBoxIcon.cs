using System;

namespace OneShot.NativeTools.Windows
{
    #if UNITY_STANDALONE_WIN
    /// <summary>
    /// what icon should it use (native only)<br/>
    /// <a href="https://learn.microsoft.com/en-us/windows/win32/api/winuser/nf-winuser-messagebox#parameters">See Microsoft Docs</a>
    /// </summary>
    
    [Flags]
    public enum MessageBoxIcon : uint
    {
        ICON_ERROR = 0x00000010,
        ICON_QUESTION = 0x00000020,
        ICON_WARNING = 0x00000030,
        ICON_INFO = 0x00000040,
        
    }
    #endif
}