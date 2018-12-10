using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCProgressViewColorThemer))]
interface MDCProgressViewColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toProgressView:(MDCProgressView * _Nonnull)progressView;
    [Static]
    [Export ("applyColorScheme:toProgressView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCProgressView progressView);
}