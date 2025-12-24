//
//  ButtonType.swift
//  oneshot-3d-nativetools
//
//  Created by Alex on 24.12.2025.
//

import Foundation

 enum ButtonType : Int32, CustomStringConvertible  {
    case OK = 0
    case OKYESNO = 2
    case YESNO = 1
    
    var description : String {
        switch self {
        case .OK: return "Ok"
        case .OKYESNO: return "Ok Yes No"
        case .YESNO: return "Yes No"
        }
    }
}
