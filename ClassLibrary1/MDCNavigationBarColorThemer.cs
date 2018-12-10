using Foundation;

[BaseType (typeof(NSObject))]
interface MDCNavigationBarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
    [Static]
    [Export ("applySemanticColorScheme:toNavigationBar:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCNavigationBar navigationBar);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toNavigationBar:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCNavigationBar navigationBar);
}