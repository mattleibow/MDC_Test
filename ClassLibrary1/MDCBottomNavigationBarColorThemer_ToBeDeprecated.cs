using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCBottomNavigationBarColorThemer))]
interface MDCBottomNavigationBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar;
    [Static]
    [Export ("applyColorScheme:toBottomNavigationBar:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCBottomNavigationBar bottomNavigationBar);
}