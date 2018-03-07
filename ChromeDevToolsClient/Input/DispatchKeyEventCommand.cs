namespace Zu.ChromeDevTools.Input
{
    using Newtonsoft.Json;

    /// <summary>
    /// Dispatches a key event to the page.
    /// </summary>
    public sealed class DispatchKeyEventCommand : ICommand
    {
        private const string ChromeRemoteInterface_CommandName = "Input.dispatchKeyEvent";
        
        [JsonIgnore]
        public string CommandName
        {
            get { return ChromeRemoteInterface_CommandName; }
        }

        /// <summary>
        /// Type of the key event.
        /// </summary>
        [JsonProperty("type")]
        public string Type
        {
            get;
            set;
        }
        /// <summary>
        /// Bit field representing pressed modifier keys. Alt=1, Ctrl=2, Meta/Command=4, Shift=8
        /// (default: 0).
        /// </summary>
        [JsonProperty("modifiers", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Modifiers
        {
            get;
            set;
        }
        /// <summary>
        /// Time at which the event occurred.
        /// </summary>
        [JsonProperty("timestamp", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public double? Timestamp
        {
            get;
            set;
        }
        /// <summary>
        /// Text as generated by processing a virtual key code with a keyboard layout. Not needed for
        /// for `keyUp` and `rawKeyDown` events (default: "")
        /// </summary>
        [JsonProperty("text", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text
        {
            get;
            set;
        }
        /// <summary>
        /// Text that would have been generated by the keyboard if no modifiers were pressed (except for
        /// shift). Useful for shortcut (accelerator) key handling (default: "").
        /// </summary>
        [JsonProperty("unmodifiedText", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string UnmodifiedText
        {
            get;
            set;
        }
        /// <summary>
        /// Unique key identifier (e.g., 'U+0041') (default: "").
        /// </summary>
        [JsonProperty("keyIdentifier", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string KeyIdentifier
        {
            get;
            set;
        }
        /// <summary>
        /// Unique DOM defined string value for each physical key (e.g., 'KeyA') (default: "").
        /// </summary>
        [JsonProperty("code", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Code
        {
            get;
            set;
        }
        /// <summary>
        /// Unique DOM defined string value describing the meaning of the key in the context of active
        /// modifiers, keyboard layout, etc (e.g., 'AltGr') (default: "").
        /// </summary>
        [JsonProperty("key", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Key
        {
            get;
            set;
        }
        /// <summary>
        /// Windows virtual key code (default: 0).
        /// </summary>
        [JsonProperty("windowsVirtualKeyCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? WindowsVirtualKeyCode
        {
            get;
            set;
        }
        /// <summary>
        /// Native virtual key code (default: 0).
        /// </summary>
        [JsonProperty("nativeVirtualKeyCode", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? NativeVirtualKeyCode
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the event was generated from auto repeat (default: false).
        /// </summary>
        [JsonProperty("autoRepeat", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AutoRepeat
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the event was generated from the keypad (default: false).
        /// </summary>
        [JsonProperty("isKeypad", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsKeypad
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the event was a system key event (default: false).
        /// </summary>
        [JsonProperty("isSystemKey", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsSystemKey
        {
            get;
            set;
        }
        /// <summary>
        /// Whether the event was from the left or right side of the keyboard. 1=Left, 2=Right (default:
        /// 0).
        /// </summary>
        [JsonProperty("location", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? Location
        {
            get;
            set;
        }
    }

    public sealed class DispatchKeyEventCommandResponse : ICommandResponse<DispatchKeyEventCommand>
    {
    }
}