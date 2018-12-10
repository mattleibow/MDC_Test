using Foundation;

[BaseType (typeof(NSObject))]
interface MDCButtonBarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
    [Static]
    [Export ("applyTypographyScheme:toButtonBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCButtonBar buttonBar);
}