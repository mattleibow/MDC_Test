using Foundation;

[BaseType (typeof(NSObject))]
interface MDCListTypographyThemer
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming>)typographyScheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
    [Static]
    [Export ("applyTypographyScheme:toSelfSizingStereoCell:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCSelfSizingStereoCell cell);
}