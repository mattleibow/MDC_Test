using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCAlertScheme : IMDCAlertScheming
{
    // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Export ("colorScheme", ArgumentSemantic.Assign)]
    MDCColorScheming ColorScheme { get; set; }

    // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Export ("typographyScheme", ArgumentSemantic.Assign)]
    MDCTypographyScheming TypographyScheme { get; set; }

    // @property (readwrite, nonatomic) id<MDCButtonScheming> _Nonnull buttonScheme;
    [Export ("buttonScheme", ArgumentSemantic.Assign)]
    MDCButtonScheming ButtonScheme { get; set; }

    // @property (readwrite, nonatomic) CGFloat cornerRadius;
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; set; }

    // @property (readwrite, nonatomic) MDCShadowElevation elevation;
    [Export ("elevation")]
    double Elevation { get; set; }
}