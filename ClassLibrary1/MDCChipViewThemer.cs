using Foundation;

[BaseType (typeof(NSObject))]
interface MDCChipViewThemer
{
    // +(void)applyScheme:(id<MDCChipViewScheming> _Nonnull)scheme toChipView:(MDCChipView * _Nonnull)chip;
    [Static]
    [Export ("applyScheme:toChipView:")]
    void ApplyScheme (MDCChipViewScheming scheme, MDCChipView chip);

    // +(void)applyOutlinedVariantWithScheme:(id<MDCChipViewScheming> _Nonnull)scheme toChipView:(MDCChipView * _Nonnull)chip;
    [Static]
    [Export ("applyOutlinedVariantWithScheme:toChipView:")]
    void ApplyOutlinedVariantWithScheme (MDCChipViewScheming scheme, MDCChipView chip);
}