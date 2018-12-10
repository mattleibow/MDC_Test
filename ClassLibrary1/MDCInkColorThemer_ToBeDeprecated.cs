using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCInkColorThemer))]
interface MDCInkColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toInkView:(MDCInkView * _Nonnull)inkView;
    [Static]
    [Export ("applyColorScheme:toInkView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCInkView inkView);
}