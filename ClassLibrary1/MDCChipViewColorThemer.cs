using Foundation;

[BaseType (typeof(NSObject))]
interface MDCChipViewColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
    [Static]
    [Export ("applySemanticColorScheme:toChipView:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCChipView chipView);

    // +(void)applyOutlinedVariantWithColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toChipView:(MDCChipView * _Nonnull)chipView;
    [Static]
    [Export ("applyOutlinedVariantWithColorScheme:toChipView:")]
    void ApplyOutlinedVariantWithColorScheme (MDCColorScheming colorScheme, MDCChipView chipView);
}