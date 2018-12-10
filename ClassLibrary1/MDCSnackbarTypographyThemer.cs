using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSnackbarTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme;
    [Static]
    [Export ("applyTypographyScheme:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme);
}