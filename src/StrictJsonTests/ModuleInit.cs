public static class ModuleInit
{
    #region UseStrictJson

    [ModuleInitializer]
    public static void Init() =>
        VerifierSettings.UseStrictJson();

    #endregion

    [ModuleInitializer]
    public static void InitDerivePath() =>
        DerivePath(
            (_, _, type, method, _) => new(AttributeReader.GetProjectDirectory(), typeName: type.Name, method.Name));
}
