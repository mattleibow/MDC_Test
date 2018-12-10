using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCTabBarColorThemer))]
interface MDCTabBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toTabBar:(MDCTabBar * _Nonnull)tabBar;
    [Static]
    [Export ("applyColorScheme:toTabBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCTabBar tabBar);
}