using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCPageControlColorThemer))]
interface MDCPageControlColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toPageControl:(MDCPageControl * _Nonnull)pageControl;
    [Static]
    [Export ("applyColorScheme:toPageControl:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCPageControl pageControl);
}