using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAppBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
    [Static]
    [Export ("applyTypographyScheme:toAppBarViewController:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAppBarViewController appBarViewController);
}