using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAlertControllerThemer
{
    // +(void)applyScheme:(id<MDCAlertScheming> _Nonnull)alertScheme toAlertController:(MDCAlertController * _Nonnull)alertController;
    [Static]
    [Export ("applyScheme:toAlertController:")]
    void ApplyScheme (MDCAlertScheming alertScheme, MDCAlertController alertController);
}