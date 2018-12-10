using Foundation;

[BaseType (typeof(NSObject))]
interface MDCActivityIndicatorColorThemer
{
    // +(void)applySemanticColorScheme:(id<MDCColorScheming> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator;
    [Static]
    [Export ("applySemanticColorScheme:toActivityIndicator:")]
    void ApplySemanticColorScheme (MDCColorScheming colorScheme, MDCActivityIndicator activityIndicator);
}