using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCShapeCategory
{
    // @property (nonatomic, strong) MDCCornerTreatment * topLeftCorner;
    [Export ("topLeftCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment TopLeftCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * topRightCorner;
    [Export ("topRightCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment TopRightCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * bottomLeftCorner;
    [Export ("bottomLeftCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment BottomLeftCorner { get; set; }

    // @property (nonatomic, strong) MDCCornerTreatment * bottomRightCorner;
    [Export ("bottomRightCorner", ArgumentSemantic.Strong)]
    MDCCornerTreatment BottomRightCorner { get; set; }

    // -(instancetype)initCornersWithFamily:(MDCShapeCornerFamily)cornerFamily andSize:(CGFloat)cornerSize;
    [Export ("initCornersWithFamily:andSize:")]
    IntPtr Constructor (MDCShapeCornerFamily cornerFamily, nfloat cornerSize);
}