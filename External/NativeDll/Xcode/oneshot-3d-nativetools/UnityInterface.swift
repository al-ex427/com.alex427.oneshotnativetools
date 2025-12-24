//
//  UnityInterface.swift
//  OneShotNatives-macos
//
//  Created by Alex on 23.12.2025.
//

import Foundation



@_cdecl("NotifyUser")
public func NotifyUser(message:String, header:String) {
    
}

// ======[ WINDOW UTILS ]======     //
@_cdecl("SetTitle")
public func SetTitle(title: UnsafePointer<CChar>) -> Bool {
    return WindowUtils.SetTitle(title:title)
}

@_cdecl("TrySetWindow")
public func TrySetWindow() -> Bool {
    return WindowUtils.TrySetWindow();
}
