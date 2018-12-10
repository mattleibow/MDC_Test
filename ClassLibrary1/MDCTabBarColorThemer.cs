using Foundation;

[BaseType (typeof(NSObject))]
interface MDCTabBarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
    [Static]
    [Export ("applySemanticColorScheme:toTabs:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCTabBar tabBar);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toTabs:(MDCTabBar * _Nonnull)tabBar;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toTabs:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCTabBar tabBar);
}