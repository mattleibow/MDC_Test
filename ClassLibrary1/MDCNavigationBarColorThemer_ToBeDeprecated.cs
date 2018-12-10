using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCNavigationBarColorThemer))]
interface MDCNavigationBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toNavigationBar:(MDCNavigationBar * _Nonnull)navigationBar;
    [Static]
    [Export ("applyColorScheme:toNavigationBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCNavigationBar navigationBar);
}