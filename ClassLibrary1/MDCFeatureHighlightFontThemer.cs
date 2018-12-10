using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFeatureHighlightFontThemer
{
    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
    [Static]
    [Export ("applyFontScheme:toFeatureHighlightView:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCFeatureHighlightView featureHighlightView);
}