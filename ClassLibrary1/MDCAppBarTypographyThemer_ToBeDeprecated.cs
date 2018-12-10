using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDCAppBarTypographyThemer))]
interface MDCAppBarTypographyThemer_ToBeDeprecated
{
    // +(void)applyTypographyScheme:(id<MDCTypographyScheming> _Nonnull)typographyScheme toAppBar:(MDCAppBar * _Nonnull)appBar;
    [Static]
    [Export ("applyTypographyScheme:toAppBar:")]
    void ApplyTypographyScheme (MDCTypographyScheming typographyScheme, MDCAppBar appBar);
}