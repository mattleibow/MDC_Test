using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCAppBarColorThemer))]
interface MDCAppBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applyColorScheme:toAppBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCAppBar appBar);

    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applySemanticColorScheme:toAppBar:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);

    // +(void)applySurfaceVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applySurfaceVariantWithColorScheme:toAppBar:")]
    void ApplySurfaceVariantWithColorScheme (MDCColorScheming colorScheme, MDCAppBar appBar);
}