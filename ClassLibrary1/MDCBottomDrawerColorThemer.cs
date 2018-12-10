using Foundation;

[BaseType (typeof(NSObject))]
interface MDCBottomDrawerColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomDrawer:(MDCBottomDrawerViewController * _Nonnull)bottomDrawer;
    [Static]
    [Export ("applySemanticColorScheme:toBottomDrawer:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCBottomDrawerViewController bottomDrawer);
}