namespace VerifyXunit;

/// <summary>
/// Signature for deriving a custom path information for `.verified.` files.
/// </summary>
/// <param name="sourceFile">The source file derived from <see cref="CallerFilePathAttribute" />.</param>
/// <param name="projectDirectory">The directory of the project that the test was compile from.</param>
/// <param name="type">The class the test method exists in.</param>
/// <param name="method">The test method.</param>
[Obsolete("Use DerivePath")]
public delegate PathInfo DerivePathInfo(string sourceFile, string projectDirectory, Type type, MethodInfo method);

/// <summary>
/// Signature for deriving a custom path information for `.verified.` files.
/// </summary>
/// <param name="sourceFile">The source file derived from <see cref="CallerFilePathAttribute" />.</param>
/// <param name="projectDirectory">The directory of the project that the test was compile from.</param>
/// <param name="type">The class the test method exists in.</param>
/// <param name="method">The test method.</param>
/// <param name="context"> Allows extensions to Verify to pass config via <see cref="VerifySettings" />.</param>
public delegate PathInfo DerivePath(string sourceFile, string projectDirectory, Type type, MethodInfo method, IReadOnlyDictionary<string, object> context);