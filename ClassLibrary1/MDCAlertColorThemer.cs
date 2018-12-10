using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAlertColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
    [Static]
    [Export ("applySemanticColorScheme:toAlertController:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCAlertController alertController);
}