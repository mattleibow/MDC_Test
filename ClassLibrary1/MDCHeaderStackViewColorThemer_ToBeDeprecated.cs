using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCHeaderStackViewColorThemer))]
interface MDCHeaderStackViewColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toHeaderStackView:(MDCHeaderStackView * _Nonnull)headerStackView;
    [Static]
    [Export ("applyColorScheme:toHeaderStackView:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCHeaderStackView headerStackView);
}