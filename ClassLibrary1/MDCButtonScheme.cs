using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCButtonScheme : IMDCButtonScheming
{
    // @property (readwrite, nonatomic) id<MDCColorScheming> _Nonnull colorScheme;
    [Export ("colorScheme", ArgumentSemantic.Assign)]
    MDCColorScheming ColorScheme { get; set; }

    // @property (readwrite, nonatomic) id<MDCShapeScheming> _Nonnull shapeScheme;
    [Export ("shapeScheme", ArgumentSemantic.Assign)]
    MDCShapeScheming ShapeScheme { get; set; }

    // @property (readwrite, nonatomic) id<MDCTypographyScheming> _Nonnull typographyScheme;
    [Export ("typographyScheme", ArgumentSemantic.Assign)]
    MDCTypographyScheming TypographyScheme { get; set; }

    // @property (readwrite, nonatomic) CGFloat cornerRadius;
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; set; }

    // @property (readwrite, nonatomic) CGFloat minimumHeight;
    [Export ("minimumHeight")]
    nfloat MinimumHeight { get; set; }
}