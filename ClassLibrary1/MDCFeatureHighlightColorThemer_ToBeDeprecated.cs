using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCFeatureHighlightColorThemer))]
interface MDCFeatureHighlightColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toFeatureHighlightView:(MDCFeatureHighlightView * _Nonnull)featureHighlightView;
    [Static]
    [Export ("applyColorScheme:toFeatureHighlightView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCFeatureHighlightView featureHighlightView);
}