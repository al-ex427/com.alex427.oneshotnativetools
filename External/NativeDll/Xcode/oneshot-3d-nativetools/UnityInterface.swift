//
//  UnityInterface.swift
//  OneShotNatives-macos
//
//  Created by Alex on 23.12.2025.
//

import Foundation

@_cdecl("SetTitle")
public func SetTitle(title: UnsafePointer<CChar>) -> Void {
    WindowUtils.SetTitle(title:title)
}

@_cdecl("NotifyUser")
public func NotifyUser(message:String, header:String) {
    
}
