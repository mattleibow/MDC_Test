using Foundation;

[BaseType (typeof(NSObject))]
interface MDCChipViewTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toChipView:(MDCChipView * _Nonnull)chipView;
    [Static]
    [Export ("applyTypographyScheme:toChipView:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCChipView chipView);
}