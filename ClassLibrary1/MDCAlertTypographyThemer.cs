using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAlertTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
    [Static]
    [Export ("applyTypographyScheme:toAlertController:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAlertController alertController);
}