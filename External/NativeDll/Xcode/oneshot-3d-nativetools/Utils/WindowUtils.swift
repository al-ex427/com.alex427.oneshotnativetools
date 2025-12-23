//
//  WindowUtils.swift
//  OneShotNatives-macos
//
//  Created by Alex on 23.12.2025.
//

import Foundation
import Cocoa
import ObjectiveC

@objc
public class WindowUtils : NSObject {
    
    @objc
    public static func SetTitle(title:UnsafePointer<CChar>) -> Void {
        guard let window = NSApplication.shared.mainWindow ?? NSApplication.shared.keyWindow else {
            print("unable to get window")
            return;
        }
        window.title = String(cString: title)
        
        
    }
}
