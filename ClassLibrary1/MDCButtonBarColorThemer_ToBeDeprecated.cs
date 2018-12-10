using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCButtonBarColorThemer))]
interface MDCButtonBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toButtonBar:(MDCButtonBar * _Nonnull)buttonBar;
    [Static]
    [Export ("applyColorScheme:toButtonBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCButtonBar buttonBar);
}