// ReSharper disable UnusedParameter.Local

namespace VerifyMSTest;

public partial class VerifyBase
{
    static DerivePath derivePath = PathInfo.DeriveDefault;

    internal static PathInfo GetPathInfo(string sourceFile, Type type, MethodInfo method, IReadOnlyDictionary<string, object> context) =>
        derivePath(sourceFile, TargetAssembly.ProjectDir, type, method, context);

    /// <summary>
    /// Use custom path information for `.verified.` files.
    /// </summary>
    /// <remarks>
    /// This is sometimes needed on CI systems that move/remove the original source.
    /// To move to this approach, any existing `.verified.` files will need to be moved to the new directory
    /// </remarks>
    /// <param name="derivePathInfo">Custom callback to control the behavior.</param>
    [Obsolete("Use DerivePath")]
    public static void DerivePathInfo(DerivePathInfo derivePathInfo) =>
        derivePath = (file, directory, type, method, context) => derivePathInfo(file, directory, type, method);

    /// <summary>
    /// Use custom path information for `.verified.` files.
    /// </summary>
    /// <remarks>
    /// This is sometimes needed on CI systems that move/remove the original source.
    /// To move to this approach, any existing `.verified.` files will need to be moved to the new directory
    /// </remarks>
    /// <param name="derivePath">Custom callback to control the behavior.</param>
    public static void DerivePath(DerivePath derivePath) =>
        VerifyBase.derivePath = derivePath;
}