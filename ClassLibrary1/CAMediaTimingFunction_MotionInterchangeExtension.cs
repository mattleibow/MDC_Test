using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(CAMediaTimingFunction))]
interface CAMediaTimingFunction_MotionInterchangeExtension
{
    // -(CAMediaTimingFunction * _Nonnull)mdm_reversed;
    [Export ("mdm_reversed")]
    [Verify (MethodToProperty)]
    CAMediaTimingFunction Mdm_reversed { get; }

    // @property (readonly, assign, nonatomic) CGPoint mdm_point1;
    [Export ("mdm_point1", ArgumentSemantic.Assign)]
    CGPoint Mdm_point1 { get; }

    // @property (readonly, assign, nonatomic) CGPoint mdm_point2;
    [Export ("mdm_point2", ArgumentSemantic.Assign)]
    CGPoint Mdm_point2 { get; }
}