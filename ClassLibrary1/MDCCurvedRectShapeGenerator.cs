using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCCurvedRectShapeGenerator : IMDCShapeGenerating
{
    // @property (assign, nonatomic) CGSize cornerSize;
    [Export ("cornerSize", ArgumentSemantic.Assign)]
    CGSize CornerSize { get; set; }

    // -(instancetype)initWithCornerSize:(CGSize)cornerSize __attribute__((objc_designated_initializer));
    [Export ("initWithCornerSize:")]
    [DesignatedInitializer]
    IntPtr Constructor (CGSize cornerSize);
}