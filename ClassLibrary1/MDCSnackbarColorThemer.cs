using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSnackbarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme;
    [Static]
    [Export ("applySemanticColorScheme:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme);
}