﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace KWAssistant.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("KWAssistant.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   使用此强类型资源类，为所有资源查找
        ///   重写当前线程的 CurrentUICulture 属性。
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
        ///   查找类似 Task is running... 的本地化字符串。
        /// </summary>
        internal static string CannotAddTask {
            get {
                return ResourceManager.GetString("CannotAddTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Are you sure you want to delete? 的本地化字符串。
        /// </summary>
        internal static string deleteTip {
            get {
                return ResourceManager.GetString("deleteTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Done 的本地化字符串。
        /// </summary>
        internal static string doneStatus {
            get {
                return ResourceManager.GetString("doneStatus", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Group name is already exist 的本地化字符串。
        /// </summary>
        internal static string existTip {
            get {
                return ResourceManager.GetString("existTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 ignore 的本地化字符串。
        /// </summary>
        internal static string ignoreTask {
            get {
                return ResourceManager.GetString("ignoreTask", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Invalid data 的本地化字符串。
        /// </summary>
        internal static string invalidTip {
            get {
                return ResourceManager.GetString("invalidTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 network error! 的本地化字符串。
        /// </summary>
        internal static string networkError {
            get {
                return ResourceManager.GetString("networkError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Can not be null 的本地化字符串。
        /// </summary>
        internal static string nullTip {
            get {
                return ResourceManager.GetString("nullTip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Failed to read keyword list! 的本地化字符串。
        /// </summary>
        internal static string readKwError {
            get {
                return ResourceManager.GetString("readKwError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Tip 的本地化字符串。
        /// </summary>
        internal static string Tip {
            get {
                return ResourceManager.GetString("Tip", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 waiting... 的本地化字符串。
        /// </summary>
        internal static string toDoStatus {
            get {
                return ResourceManager.GetString("toDoStatus", resourceCulture);
            }
        }
    }
}
