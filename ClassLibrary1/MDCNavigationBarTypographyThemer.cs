using Foundation;

[BaseType (typeof(NSObject))]
interface MDCNavigationBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
    [Static]
    [Export ("applyTypographyScheme:toNavigationBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCNavigationBar navigationBar);
}