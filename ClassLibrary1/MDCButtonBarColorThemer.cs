using Foundation;

[BaseType (typeof(NSObject))]
interface MDCButtonBarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
    [Static]
    [Export ("applySemanticColorScheme:toButtonBar:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCButtonBar buttonBar);
}