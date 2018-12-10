using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
interface MDCCornerTreatment : INSCopying, INSSecureCoding
{
    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(MDCPathGenerator * _Nonnull)pathGeneratorForCornerWithAngle:(CGFloat)angle;
    [Export ("pathGeneratorForCornerWithAngle:")]
    MDCPathGenerator PathGeneratorForCornerWithAngle (nfloat angle);
}