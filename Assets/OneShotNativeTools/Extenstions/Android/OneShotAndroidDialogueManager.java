package com.alex427.oneshot-nativetools;

public class OneShotAndroidDialogueManager {
    private static OneShotAndroidDialogueManager;
    
    public static OneShotAndroidDialogueManager getInstance() {
        if (_instance == null) {
            _instance = new OneShotAndroidDialogueManager();
        }
        return _instance;
    }
}