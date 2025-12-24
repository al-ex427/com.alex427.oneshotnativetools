//
//  WindowUtils.swift
//  OneShotNatives-macos
//
//  Created by Alex on 23.12.2025.
//

import Foundation
import Cocoa
import ObjectiveC

enum WindowUtilsError: Error {
    case WindowUnappliedChange
}
@objc
public class WindowUtils : NSObject {
    public static var gameWindow: NSWindow? = nil;
    
    @objc
    public static func TrySetWindow() -> Bool {
        guard let window = NSApplication.shared.mainWindow ?? NSApplication.shared.keyWindow else {
            return false;
        }
        gameWindow = window;
        return true;
    }
    
    @objc
    public static func SetTitle(title:UnsafePointer<CChar>) -> Bool {
        do {
            let sTitle:String = String(cString: title);
            gameWindow?.title = sTitle
            if (gameWindow?.title != sTitle) {
                throw WindowUtilsError.WindowUnappliedChange
            }
            return true;
        } catch let error {
            print(error)
            return false;
        }
        
        
    }
}
