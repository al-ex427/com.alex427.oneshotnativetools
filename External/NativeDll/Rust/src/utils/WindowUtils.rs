
    use windows::core::{PCWSTR};
    use windows::Win32::UI::Input::KeyboardAndMouse::{GetActiveWindow};
    use windows::Win32::UI::WindowsAndMessaging::{GetWindowTextW, SetWindowTextW};
    use windows::Win32::Foundation::{HWND};

    pub static mut GAME_WINDOW: Option<HWND> = None;

    pub unsafe fn try_set_window() -> bool {
        unsafe {
            let window:HWND = GetActiveWindow();
            if window.is_invalid() {
               return false
            }
            GAME_WINDOW = Some(window);
            true
        }
    }


    fn u8_to_string(string: *const u8) -> &'static str {
        unsafe {
            std::str::from_utf8(std::slice::from_raw_parts(string, 512)).unwrap_or("")
        }
    }

    pub unsafe fn set_title(title: *const u8) -> bool {
        unsafe {
            match GAME_WINDOW {
                Some(ref game_window_hwnd) => {
                    
                    let target_title = PCWSTR(u8_to_string(title).as_ptr() as *const u16);
                    SetWindowTextW(*game_window_hwnd, target_title).ok();


                    let mut buffer = vec![0u16, 512];

                    let len =  GetWindowTextW(*game_window_hwnd, buffer.as_mut_slice()) ;
                    if len == 0 { return false }

                    if String::from_utf16_lossy(&buffer[..len as usize]) != target_title.to_string().unwrap() {
                        return false;
                    }

                    true
                }
                None => false,
            }
        }
    }