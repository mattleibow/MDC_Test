using Foundation;

[BaseType (typeof(NSObject))]
interface MDCListThemer
{
    // +(void)applyScheme:(id<MDCListScheming>)scheme toSelfSizingStereoCell:(MDCSelfSizingStereoCell *)cell;
    [Static]
    [Export ("applyScheme:toSelfSizingStereoCell:")]
    void ApplyScheme (MDCListScheming scheme, MDCSelfSizingStereoCell cell);

    // +(void)applyScheme:(id<MDCListScheming>)scheme toBaseCell:(MDCBaseCell *)cell;
    [Static]
    [Export ("applyScheme:toBaseCell:")]
    void ApplyScheme (MDCListScheming scheme, MDCBaseCell cell);
}