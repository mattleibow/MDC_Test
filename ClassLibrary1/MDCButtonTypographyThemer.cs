using Foundation;

[BaseType (typeof(NSObject))]
interface MDCButtonTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applyTypographyScheme:toButton:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCButton button);
}