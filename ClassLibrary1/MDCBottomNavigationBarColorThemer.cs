using Foundation;

[BaseType (typeof(NSObject))]
interface MDCBottomNavigationBarColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomNavigation:(MDCBottomNavigationBar * _Nonnull)bottomNavigation;
    [Static]
    [Export ("applySemanticColorScheme:toBottomNavigation:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCBottomNavigationBar bottomNavigation);
}