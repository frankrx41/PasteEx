﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace PasteEx.Properties {

    [global::System.Configuration.SettingsProvider(typeof(PasteEx.MySettingsProvider))]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.8.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool firstTipFlag {
            get {
                return ((bool)(this["firstTipFlag"]));
            }
            set {
                this["firstTipFlag"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string autoExtRule {
            get {
                return ((string)(this["autoExtRule"]));
            }
            set {
                this["autoExtRule"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool autoExtSwitch {
            get {
                return ((bool)(this["autoExtSwitch"]));
            }
            set {
                this["autoExtSwitch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string guid {
            get {
                return ((string)(this["guid"]));
            }
            set {
                this["guid"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.DateTime lastBootTime {
            get {
                return ((global::System.DateTime)(this["lastBootTime"]));
            }
            set {
                this["lastBootTime"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string language {
            get {
                return ((string)(this["language"]));
            }
            set {
                this["language"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ctrl + Alt + X")]
        public string pasteHotkey {
            get {
                return ((string)(this["pasteHotkey"]));
            }
            set {
                this["pasteHotkey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool autoImageToFileEnabled {
            get {
                return ((bool)(this["autoImageToFileEnabled"]));
            }
            set {
                this["autoImageToFileEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string monitorAutoSavePath {
            get {
                return ((string)(this["monitorAutoSavePath"]));
            }
            set {
                this["monitorAutoSavePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Clip_$yyyyMMdd_HHmmss$")]
        public string fileNamePattern {
            get {
                return ((string)(this["fileNamePattern"]));
            }
            set {
                this["fileNamePattern"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool monitorAutoSaveEnabled {
            get {
                return ((bool)(this["monitorAutoSaveEnabled"]));
            }
            set {
                this["monitorAutoSaveEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool DefaultStartupMonitorModeEnabled {
            get {
                return ((bool)(this["DefaultStartupMonitorModeEnabled"]));
            }
            set {
                this["DefaultStartupMonitorModeEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Exclude")]
        public string ApplicationFilterState {
            get {
                return ((string)(this["ApplicationFilterState"]));
            }
            set {
                this["ApplicationFilterState"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApplicationFilterInclude {
            get {
                return ((string)(this["ApplicationFilterInclude"]));
            }
            set {
                this["ApplicationFilterInclude"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ApplicationFilterExclude {
            get {
                return ((string)(this["ApplicationFilterExclude"]));
            }
            set {
                this["ApplicationFilterExclude"] = value;
            }
        }
    }
}
