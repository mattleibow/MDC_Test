using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(MDCCornerTreatment))]
interface MDCCurvedCornerTreatment
{
    // @property (assign, nonatomic) CGSize size;
    [Export ("size", ArgumentSemantic.Assign)]
    CGSize Size { get; set; }

    // -(instancetype _Nonnull)initWithSize:(CGSize)size __attribute__((objc_designated_initializer));
    [Export ("initWithSize:")]
    [DesignatedInitializer]
    IntPtr Constructor (CGSize size);
}