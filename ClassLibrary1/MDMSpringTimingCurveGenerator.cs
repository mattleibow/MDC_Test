using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMSpringTimingCurveGenerator : INSCopying, IMDMTimingCurve
{
    // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration dampingRatio:(CGFloat)dampingRatio;
    [Export ("initWithDuration:dampingRatio:")]
    IntPtr Constructor (double duration, nfloat dampingRatio);

    // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration dampingRatio:(CGFloat)dampingRatio initialVelocity:(CGFloat)initialVelocity __attribute__((objc_designated_initializer));
    [Export ("initWithDuration:dampingRatio:initialVelocity:")]
    [DesignatedInitializer]
    IntPtr Constructor (double duration, nfloat dampingRatio, nfloat initialVelocity);

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration")]
    double Duration { get; set; }

    // @property (assign, nonatomic) CGFloat dampingRatio;
    [Export ("dampingRatio")]
    nfloat DampingRatio { get; set; }

    // @property (assign, nonatomic) CGFloat initialVelocity;
    [Export ("initialVelocity")]
    nfloat InitialVelocity { get; set; }

    // -(MDMSpringTimingCurve * _Nonnull)springTimingCurve;
    [Export ("springTimingCurve")]
    [Verify (MethodToProperty)]
    MDMSpringTimingCurve SpringTimingCurve { get; }
}