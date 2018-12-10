using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(MDCCornerTreatment))]
interface MDCRoundedCornerTreatment
{
    // @property (assign, nonatomic) CGFloat radius;
    [Export ("radius")]
    nfloat Radius { get; set; }

    // -(instancetype _Nonnull)initWithRadius:(CGFloat)radius __attribute__((objc_designated_initializer));
    [Export ("initWithRadius:")]
    [DesignatedInitializer]
    IntPtr Constructor (nfloat radius);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);
}