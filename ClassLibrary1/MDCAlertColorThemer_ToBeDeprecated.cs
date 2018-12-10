using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCAlertColorThemer))]
interface MDCAlertColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme;
    [Static]
    [Export ("applyColorScheme:")]
    void ApplyColorScheme (MDCColorScheme colorScheme);
}