using Foundation;

[BaseType (typeof(NSObject))]
interface MDCBottomNavigationBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
    [Static]
    [Export ("applyTypographyScheme:toBottomNavigationBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCBottomNavigationBar bottomNavigationBar);
}