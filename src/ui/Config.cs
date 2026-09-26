using System;

using BepInEx.Configuration;
using UnityEngine;

namespace FullGameTimer {
    public class Config {
        public ConfigEntry<string> _toggleKeybind;
        public ConfigEntry<bool> showUI;
        public ConfigEntry<bool> showExtended;

        public KeyCode toggleKeybind {
            get => (KeyCode) Enum.Parse(typeof(KeyCode), _toggleKeybind.Value);
            set => _toggleKeybind.Value = value.ToString();
        }
    }
}
