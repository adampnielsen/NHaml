//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace NHaml.Properties
{
  /// <summary>
  ///   A strongly-typed resource class, for looking up localized strings, etc.
  /// </summary>
  // This class was auto-generated by the StronglyTypedResourceBuilder
  // class via a tool like ResGen or Visual Studio.
  // To add or remove a member, edit your .ResX file then rerun ResGen
  // with the /str option, or rebuild your VS project.
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;

    private static CultureInfo resourceCulture;

    [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources()
    {
    }

    /// <summary>
    ///   Returns the cached ResourceManager instance used by this class.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (ReferenceEquals(resourceMan, null))
        {
          var temp = new ResourceManager("NHaml.Properties.Resources", typeof(Resources).Assembly);
          resourceMan = temp;
        }
        return resourceMan;
      }
    }

    /// <summary>
    ///   Overrides the current thread's CurrentUICulture property for all
    ///   resource lookups using this strongly typed resource class.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get { return resourceCulture; }
      set { resourceCulture = value; }
    }

    /// <summary>
    ///   Looks up a localized string similar to Error parsing attributes.
    /// </summary>
    internal static string AttributesParseError
    {
      get { return ResourceManager.GetString("AttributesParseError", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to An error occurred when compiling the file: {0}.
    /// </summary>
    internal static string CompilationError
    {
      get { return ResourceManager.GetString("CompilationError", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Compiler back-end type {0} not found.
    /// </summary>
    internal static string CompilerBackEndTypeNotFound
    {
      get { return ResourceManager.GetString("CompilerBackEndTypeNotFound", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Error parsing tag.
    /// </summary>
    internal static string ErrorParsingTag
    {
      get { return ResourceManager.GetString("ErrorParsingTag", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Illegal Indentation: Only two space characters are allowed as tabulation.
    /// </summary>
    internal static string IllegalIndentation
    {
      get { return ResourceManager.GetString("IllegalIndentation", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to ViewBaseType must inherit from CompiledTemplate.
    /// </summary>
    internal static string InvalidViewBaseType
    {
      get { return ResourceManager.GetString("InvalidViewBaseType", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invariant Failure.
    /// </summary>
    internal static string InvariantFail
    {
      get { return ResourceManager.GetString("InvariantFail", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Type {0} is not assignable to ICompilerBackEnd.
    /// </summary>
    internal static string NotAssignableToICompilerBackEnd
    {
      get { return ResourceManager.GetString("NotAssignableToICompilerBackEnd", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Expected Not Null Object.
    /// </summary>
    internal static string ObjectNull
    {
      get { return ResourceManager.GetString("ObjectNull", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to The provided string argument &quot;{0}&quot; cannot be empty.
    /// </summary>
    internal static string StringCannotBeEmpty
    {
      get { return ResourceManager.GetString("StringCannotBeEmpty", resourceCulture); }
    }

    /// <summary>
    ///   Looks up a localized string similar to Syntax error on line {0}: {1}: &quot;{2}&quot;.
    /// </summary>
    internal static string SyntaxError
    {
      get { return ResourceManager.GetString("SyntaxError", resourceCulture); }
    }
  }
}