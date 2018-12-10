using Foundation;

[BaseType (typeof(NSObject))]
interface MDCSliderColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
    [Static]
    [Export ("applySemanticColorScheme:toSlider:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCSlider slider);
}