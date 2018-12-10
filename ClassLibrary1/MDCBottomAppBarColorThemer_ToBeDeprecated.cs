using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCBottomAppBarColorThemer))]
interface MDCBottomAppBarColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toBottomAppBarView:(MDCBottomAppBarView * _Nonnull)bottomAppBarView;
    [Static]
    [Export ("applyColorScheme:toBottomAppBarView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCBottomAppBarView bottomAppBarView);
}