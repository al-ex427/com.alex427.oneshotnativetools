extern crate alloc;

// ======[ WINDOW UTILS ]======     //



mod utils;

#[unsafe(no_mangle)]
pub unsafe extern "C" fn TrySetWindow() -> bool {
  unsafe {
      utils::WindowUtils::try_set_window()
  }
}

#[unsafe(no_mangle)]
pub unsafe extern "C" fn SetTitle(title: *const u8) -> bool {
    unsafe {
        utils::WindowUtils::set_title(title)
    }
}