﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MageServer.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Strings_Commands {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_Commands() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MageServer.Resources.Strings_Commands", typeof(Strings_Commands).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your message is too short..
        /// </summary>
        internal static string Broadcast_TooShort {
            get {
                return ResourceManager.GetString("Broadcast_TooShort", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have entered an invalid amount..
        /// </summary>
        internal static string EventExp_InvalidAmount {
            get {
                return ResourceManager.GetString("EventExp_InvalidAmount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must specify an amount..
        /// </summary>
        internal static string EventExp_SpecifyAmount {
            get {
                return ResourceManager.GetString("EventExp_SpecifyAmount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your preferred event exp amount has been set to &apos;{0}&apos;..
        /// </summary>
        internal static string EventExp_Success {
            get {
                return ResourceManager.GetString("EventExp_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No targets were found..
        /// </summary>
        internal static string General_NoTargetsFound {
            get {
                return ResourceManager.GetString("General_NoTargetsFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You are not in an Arena..
        /// </summary>
        internal static string General_NotInArena {
            get {
                return ResourceManager.GetString("General_NotInArena", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You cannot kill an admin with higher privileges..
        /// </summary>
        internal static string Kill_HigherPriviledges {
            get {
                return ResourceManager.GetString("Kill_HigherPriviledges", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You were killed by a admin..
        /// </summary>
        internal static string Kill_Killed {
            get {
                return ResourceManager.GetString("Kill_Killed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You must enter a player name..
        /// </summary>
        internal static string Kill_SpecifyPlayer {
            get {
                return ResourceManager.GetString("Kill_SpecifyPlayer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} has been killed..
        /// </summary>
        internal static string Kill_TargetKilled {
            get {
                return ResourceManager.GetString("Kill_TargetKilled", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to You have set the motd to: &apos;{0}&apos;.
        /// </summary>
        internal static string Motd_Success {
            get {
                return ResourceManager.GetString("Motd_Success", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your message is too short..
        /// </summary>
        internal static string Motd_TooShort {
            get {
                return ResourceManager.GetString("Motd_TooShort", resourceCulture);
            }
        }
    }
}