using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFeatureHighlightTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toFeatureHighlightViewController:(MDCFeatureHighlightViewController * _Nonnull)featureHighlightViewController;
    [Static]
    [Export ("applyTypographyScheme:toFeatureHighlightViewController:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCFeatureHighlightViewController featureHighlightViewController);
}