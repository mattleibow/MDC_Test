using Foundation;

[BaseType (typeof(NSObject))]
interface MDCChipViewShapeThemer
{
    // +(void)applyShapeScheme:(id<MDCShapeScheming> _Nonnull)shapeScheme toChipView:(MDCChipView * _Nonnull)chipView;
    [Static]
    [Export ("applyShapeScheme:toChipView:")]
    void ApplyShapeScheme (MDCShapeScheming shapeScheme, MDCChipView chipView);
}