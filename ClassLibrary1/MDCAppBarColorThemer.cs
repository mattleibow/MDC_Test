using Foundation;

[BaseType (typeof(NSObject))]
interface MDCAppBarColorThemer
{
    // +(void)applyColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
    [Static]
    [Export ("applyColorScheme:toAppBarViewController:")]
    void ApplyColorScheme (MDCColorScheming colorScheme, MDCAppBarViewController appBarViewController);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBarViewController:(MDCAppBarViewController * _Nonnull)appBarViewController;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toAppBarViewController:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCAppBarViewController appBarViewController);
}