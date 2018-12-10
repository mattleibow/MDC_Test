using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCSliderColorThemer))]
interface MDCSliderColorThemer_ToBeDeprecated
{
    // +(void)applyColorScheme:(id<MDCColorScheme> _Nonnull)colorScheme toSlider:(MDCSlider * _Nonnull)slider;
    [Static]
    [Export ("applyColorScheme:toSlider:")]
    void ApplyColorScheme (MDCColorScheme colorScheme, MDCSlider slider);

    // +(MDCBasicColorScheme * _Nonnull)defaultSliderLightColorScheme;
    [Static]
    [Export ("defaultSliderLightColorScheme")]
    [Verify (MethodToProperty)]
    MDCBasicColorScheme DefaultSliderLightColorScheme { get; }

    // +(MDCBasicColorScheme * _Nonnull)defaultSliderDarkColorScheme;
    [Static]
    [Export ("defaultSliderDarkColorScheme")]
    [Verify (MethodToProperty)]
    MDCBasicColorScheme DefaultSliderDarkColorScheme { get; }
}