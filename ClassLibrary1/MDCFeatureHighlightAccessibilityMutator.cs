using Foundation;

[BaseType (typeof(NSObject))]
interface MDCFeatureHighlightAccessibilityMutator
{
    // +(void)mutate:(MDCFeatureHighlightViewController *)featureHighlightViewController;
    [Static]
    [Export ("mutate:")]
    void Mutate (MDCFeatureHighlightViewController featureHighlightViewController);
}