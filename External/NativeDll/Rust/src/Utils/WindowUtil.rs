use std::ptr::null_mut;
use windows::Win32::Foundation::HWND;
use windows::Win32::UI::Input::KeyboardAndMouse::GetActiveWindow;

static window: HWND = GetActiveWindow();