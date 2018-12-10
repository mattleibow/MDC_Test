using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAppBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
    [Static]
    [Export ("applyTypographyScheme:toAppBarViewController:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAppBarViewController appBarViewController);

    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applyTypographyScheme:toAppBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAppBar appBar);
}