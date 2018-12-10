using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCShapeScheme : IMDCShapeScheming
{
    // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull smallComponentShape;
    [Export ("smallComponentShape", ArgumentSemantic.Assign)]
    MDCShapeCategory SmallComponentShape { get; set; }

    // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull mediumComponentShape;
    [Export ("mediumComponentShape", ArgumentSemantic.Assign)]
    MDCShapeCategory MediumComponentShape { get; set; }

    // @property (readwrite, nonatomic) MDCShapeCategory * _Nonnull largeComponentShape;
    [Export ("largeComponentShape", ArgumentSemantic.Assign)]
    MDCShapeCategory LargeComponentShape { get; set; }

    // -(instancetype _Nonnull)initWithDefaults:(MDCShapeSchemeDefaults)defaults;
    [Export ("initWithDefaults:")]
    IntPtr Constructor (MDCShapeSchemeDefaults defaults);
}