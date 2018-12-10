using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCAppBarColorThemer))]
interface MDCAppBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applyColorScheme:toAppBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCAppBar appBar);
}