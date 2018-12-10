using Foundation;

[BaseType (typeof(NSObject))]
interface MDCBottomAppBarColorThemer
{
    // +(void)applySurfaceVariantWithSemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toBottomAppBarView:(MDCBottomAppBarView * _Nonnull)bottomAppBarView;
    [Static]
    [Export ("applySurfaceVariantWithSemanticColorScheme:toBottomAppBarView:")]
    void ApplySurfaceVariantWithSemanticColorScheme (MDCColorScheming colorScheme, MDCBottomAppBarView bottomAppBarView);
}