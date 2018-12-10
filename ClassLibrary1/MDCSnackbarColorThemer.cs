using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSnackbarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme;
    [Static]
    [Export ("applySemanticColorScheme:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toSnackbarManager:(MDCSnackbarManager * _Nonnull)snackbarManager;
    [Static]
    [Export ("applySemanticColorScheme:toSnackbarManager:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCSnackbarManager snackbarManager);
}