using Foundation;

[BaseType (typeof(NSObject))]
interface MDCTabBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
    [Static]
    [Export ("applyTypographyScheme:toTabBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCTabBar tabBar);
}