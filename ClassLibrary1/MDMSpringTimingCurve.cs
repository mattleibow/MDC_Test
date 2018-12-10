using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMSpringTimingCurve : INSCopying, IMDMTimingCurve
{
    // -(instancetype _Nonnull)initWithMass:(CGFloat)mass tension:(CGFloat)tension friction:(CGFloat)friction;
    [Export ("initWithMass:tension:friction:")]
    IntPtr Constructor (nfloat mass, nfloat tension, nfloat friction);

    // -(instancetype _Nonnull)initWithMass:(CGFloat)mass tension:(CGFloat)tension friction:(CGFloat)friction initialVelocity:(CGFloat)initialVelocity __attribute__((objc_designated_initializer));
    [Export ("initWithMass:tension:friction:initialVelocity:")]
    [DesignatedInitializer]
    IntPtr Constructor (nfloat mass, nfloat tension, nfloat friction, nfloat initialVelocity);

    // @property (assign, nonatomic) CGFloat mass;
    [Export ("mass")]
    nfloat Mass { get; set; }

    // @property (assign, nonatomic) CGFloat tension;
    [Export ("tension")]
    nfloat Tension { get; set; }

    // @property (assign, nonatomic) CGFloat friction;
    [Export ("friction")]
    nfloat Friction { get; set; }

    // @property (assign, nonatomic) CGFloat initialVelocity;
    [Export ("initialVelocity")]
    nfloat InitialVelocity { get; set; }
}