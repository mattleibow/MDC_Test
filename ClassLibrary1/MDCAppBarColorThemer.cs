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

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applySemanticColorScheme:toAppBar:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toAppBar:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);
}