using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCActivityIndicatorColorThemer))]
interface MDCActivityIndicatorColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toActivityIndicator:(MDCActivityIndicator * _Nonnull)activityIndicator;
    [Static]
    [Export ("applyColorScheme:toActivityIndicator:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCActivityIndicator activityIndicator);
}