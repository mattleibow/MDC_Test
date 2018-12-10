using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCShapedView
{
    // @property (assign, nonatomic) MDCShadowElevation elevation;
    [Export ("elevation")]
    double Elevation { get; set; }

    // @property (nonatomic, strong) id<MDCShapeGenerating> _Nullable shapeGenerator __attribute__((iboutlet));
    [NullAllowed, Export ("shapeGenerator", ArgumentSemantic.Strong)]
    MDCShapeGenerating ShapeGenerator { get; set; }

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame shapeGenerator:(id<MDCShapeGenerating> _Nullable)shapeGenerator __attribute__((objc_designated_initializer));
    [Export ("initWithFrame:shapeGenerator:")]
    [DesignatedInitializer]
    IntPtr Constructor (CGRect frame, [NullAllowed] MDCShapeGenerating shapeGenerator);
}