using Foundation;

[BaseType (typeof(NSObject))]
interface MDCOutlinedButtonColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applySemanticColorScheme:toButton:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButton button);
}