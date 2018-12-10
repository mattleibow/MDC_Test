using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFloatingButtonColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCFloatingButton * _Nonnull)button;
    [Static]
    [Export ("applySemanticColorScheme:toButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFloatingButton button);
}