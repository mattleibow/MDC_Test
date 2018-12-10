using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCCornerTreatment : INSCopying
{
    // @property (assign, nonatomic) MDCCornerTreatmentValueType valueType;
    [Export ("valueType", ArgumentSemantic.Assign)]
    MDCCornerTreatmentValueType ValueType { get; set; }

    // -(MDCPathGenerator * _Nonnull)pathGeneratorForCornerWithAngle:(CGFloat)angle;
    [Export ("pathGeneratorForCornerWithAngle:")]
    MDCPathGenerator PathGeneratorForCornerWithAngle (nfloat angle);

    // -(MDCPathGenerator * _Nonnull)pathGeneratorForCornerWithAngle:(CGFloat)angle forViewSize:(CGSize)size;
    [Export ("pathGeneratorForCornerWithAngle:forViewSize:")]
    MDCPathGenerator PathGeneratorForCornerWithAngle (nfloat angle, CGSize size);
}