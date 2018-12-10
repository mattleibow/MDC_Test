using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFloatingActionButtonThemer
{
    // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCFloatingButton * _Nonnull)button;
    [Static]
    [Export ("applyScheme:toButton:")]
    void ApplyScheme (MDCButtonScheming scheme, MDCFloatingButton button);
}