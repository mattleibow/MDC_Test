using Foundation;

[BaseType (typeof(NSObject))]
interface MDCChipViewFontThemer
{
    // +(void)applyFontScheme:(id<MDCFontScheme> _Nonnull)fontScheme toChipView:(MDCChipView * _Nonnull)chipView;
    [Static]
    [Export ("applyFontScheme:toChipView:")]
    void ApplyFontScheme (MDCFontScheme fontScheme, MDCChipView chipView);
}