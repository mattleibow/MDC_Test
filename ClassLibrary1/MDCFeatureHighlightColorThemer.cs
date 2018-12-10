using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFeatureHighlightColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
    [Static]
    [Export ("applySemanticColorScheme:toFeatureHighlightViewController:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCFeatureHighlightViewController featureHighlightViewController);
}