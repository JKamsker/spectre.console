﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Spectre.Console.Cli.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Spectre.Console.Cli.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to function Invoke-[APPNAME] {
        ///    return [RUNCOMMAND] $args
        ///}
        ///
        ///# Register-CompleterFor -CommandName [APPNAME]
        ///function Register-CompleterFor{
        ///    #appname parameter
        ///    param(
        ///        [Parameter(Mandatory=$true)]
        ///        [string]$name
        ///    )
        ///
        ///    Register-ArgumentCompleter -Native -CommandName $name -ScriptBlock {
        ///        param($commandName, $wordToComplete, $cursorPosition)
        ///        $completions = [RUNCOMMAND] cli complete --position $cursorPosition &quot;$wordToComplete&quot;
        ///        if ($completions) {        /// [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PowershellIntegration_Completion_and_alias {
            get {
                return ResourceManager.GetString("PowershellIntegration_Completion_and_alias", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to # adds for eg. Write-Host &quot;Hello World! [Randomnumber]&quot; to profile only once, otherwise does it overwrites it
        ///function Add-ProfileLine {
        ///    param(
        ///        [string]$identifier,
        ///        [string]$Line
        ///
        ///    )
        ///    $ProfilePath = $profile.CurrentUserAllHosts
        ///    $ProfileContent = Get-Content $ProfilePath
        ///    
        ///    # we need to remove Id: [identifier] and the line after it
        ///    $IdLine = &quot;#Id: $identifier&quot;
        ///    $IdLineIndex = $ProfileContent.IndexOf($IdLine)
        ///    if ($IdLineIndex -ne -1) {
        ///        $Prof [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string PowershellIntegration_Install {
            get {
                return ResourceManager.GetString("PowershellIntegration_Install", resourceCulture);
            }
        }
    }
}
