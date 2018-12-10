using Foundation;

[BaseType (typeof(NSObject))]
interface MDCTabBarFontThemer
{
    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
    [Static]
    [Export ("applyFontScheme:toTabBar:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCTabBar tabBar);
}