﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smellyriver.TankInspector {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    internal sealed partial class ApplicationSettings : global::System.Configuration.ApplicationSettingsBase {
        
        private static ApplicationSettings defaultInstance = ((ApplicationSettings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new ApplicationSettings())));
        
        public static ApplicationSettings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" />")]
        public global::System.Collections.Specialized.StringCollection GamePathes {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["GamePathes"]));
            }
            set {
                this["GamePathes"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreviousDatabaseKeyHash {
            get {
                return ((string)(this["PreviousDatabaseKeyHash"]));
            }
            set {
                this["PreviousDatabaseKeyHash"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreviousTankKey {
            get {
                return ((string)(this["PreviousTankKey"]));
            }
            set {
                this["PreviousTankKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PreviousTankGalleryPageKey {
            get {
                return ((string)(this["PreviousTankGalleryPageKey"]));
            }
            set {
                this["PreviousTankGalleryPageKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string EMailAddress {
            get {
                return ((string)(this["EMailAddress"]));
            }
            set {
                this["EMailAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SSAOEnabled {
            get {
                return ((bool)(this["SSAOEnabled"]));
            }
            set {
                this["SSAOEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SMAAEnabled {
            get {
                return ((bool)(this["SMAAEnabled"]));
            }
            set {
                this["SMAAEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool CollisionModelStrokeEnabled {
            get {
                return ((bool)(this["CollisionModelStrokeEnabled"]));
            }
            set {
                this["CollisionModelStrokeEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowFPS {
            get {
                return ((bool)(this["ShowFPS"]));
            }
            set {
                this["ShowFPS"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowModelTriangleCount {
            get {
                return ((bool)(this["ShowModelTriangleCount"]));
            }
            set {
                this["ShowModelTriangleCount"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool WireframeMode {
            get {
                return ((bool)(this["WireframeMode"]));
            }
            set {
                this["WireframeMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool SpecularTextureEnabled {
            get {
                return ((bool)(this["SpecularTextureEnabled"]));
            }
            set {
                this["SpecularTextureEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool NormalTextureEnabled {
            get {
                return ((bool)(this["NormalTextureEnabled"]));
            }
            set {
                this["NormalTextureEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool AutoLoadEliteConfigEnabled {
            get {
                return ((bool)(this["AutoLoadEliteConfigEnabled"]));
            }
            set {
                this["AutoLoadEliteConfigEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool AutoResetReferenceTankEnabled {
            get {
                return ((bool)(this["AutoResetReferenceTankEnabled"]));
            }
            set {
                this["AutoResetReferenceTankEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool HangarShowTankDescription {
            get {
                return ((bool)(this["HangarShowTankDescription"]));
            }
            set {
                this["HangarShowTankDescription"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool RecruitFullyTrainedCrews {
            get {
                return ((bool)(this["RecruitFullyTrainedCrews"]));
            }
            set {
                this["RecruitFullyTrainedCrews"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string PasswordHash {
            get {
                return ((string)(this["PasswordHash"]));
            }
            set {
                this["PasswordHash"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowPassword {
            get {
                return ((bool)(this["ShowPassword"]));
            }
            set {
                this["ShowPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowBackgroundImage {
            get {
                return ((bool)(this["ShowBackgroundImage"]));
            }
            set {
                this["ShowBackgroundImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("88")]
        public double TestShellCaliber {
            get {
                return ((double)(this["TestShellCaliber"]));
            }
            set {
                this["TestShellCaliber"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public double SniperModeDistance {
            get {
                return ((double)(this["SniperModeDistance"]));
            }
            set {
                this["SniperModeDistance"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public double TelescopeZoomRate {
            get {
                return ((double)(this["TelescopeZoomRate"]));
            }
            set {
                this["TelescopeZoomRate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("16")]
        public int AnisotropicFilterLevel {
            get {
                return ((int)(this["AnisotropicFilterLevel"]));
            }
            set {
                this["AnisotropicFilterLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowSoftwareCrosshair {
            get {
                return ((bool)(this["ShowSoftwareCrosshair"]));
            }
            set {
                this["ShowSoftwareCrosshair"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowX {
            get {
                return ((double)(this["MainWindowX"]));
            }
            set {
                this["MainWindowX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public double MainWindowY {
            get {
                return ((double)(this["MainWindowY"]));
            }
            set {
                this["MainWindowY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1280")]
        public double MainWindowWidth {
            get {
                return ((double)(this["MainWindowWidth"]));
            }
            set {
                this["MainWindowWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("700")]
        public double MainWindowHeight {
            get {
                return ((double)(this["MainWindowHeight"]));
            }
            set {
                this["MainWindowHeight"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool MainWindowMaximized {
            get {
                return ((bool)(this["MainWindowMaximized"]));
            }
            set {
                this["MainWindowMaximized"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ResetShellTypeOnChangingVehicle {
            get {
                return ((bool)(this["ResetShellTypeOnChangingVehicle"]));
            }
            set {
                this["ResetShellTypeOnChangingVehicle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool RecruitNewCrewsOnChangingVehicle {
            get {
                return ((bool)(this["RecruitNewCrewsOnChangingVehicle"]));
            }
            set {
                this["RecruitNewCrewsOnChangingVehicle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearEquipmentsOnChangingVehicle {
            get {
                return ((bool)(this["ClearEquipmentsOnChangingVehicle"]));
            }
            set {
                this["ClearEquipmentsOnChangingVehicle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ClearConsumablesOnChangingVehicle {
            get {
                return ((bool)(this["ClearConsumablesOnChangingVehicle"]));
            }
            set {
                this["ClearConsumablesOnChangingVehicle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool ShowDescriptionInDataTip {
            get {
                return ((bool)(this["ShowDescriptionInDataTip"]));
            }
            set {
                this["ShowDescriptionInDataTip"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool UseRealTraverseSpeedOnTurretController {
            get {
                return ((bool)(this["UseRealTraverseSpeedOnTurretController"]));
            }
            set {
                this["UseRealTraverseSpeedOnTurretController"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool ShowAsMuchStatsAsPossible {
            get {
                return ((bool)(this["ShowAsMuchStatsAsPossible"]));
            }
            set {
                this["ShowAsMuchStatsAsPossible"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2048")]
        public int PhotoSize {
            get {
                return ((int)(this["PhotoSize"]));
            }
            set {
                this["PhotoSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Ap")]
        public global::Smellyriver.TankInspector.Modeling.ShellType TestShellType {
            get {
                return ((global::Smellyriver.TankInspector.Modeling.ShellType)(this["TestShellType"]));
            }
            set {
                this["TestShellType"] = value;
            }
        }
    }
}
