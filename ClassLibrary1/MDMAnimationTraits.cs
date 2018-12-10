using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMAnimationTraits : INSCopying
{
    // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration;
    [Export ("initWithDuration:")]
    IntPtr Constructor (double duration);

    // -(instancetype _Nonnull)initWithDuration:(NSTimeInterval)duration animationCurve:(UIViewAnimationCurve)animationCurve;
    [Export ("initWithDuration:animationCurve:")]
    IntPtr Constructor (double duration, UIViewAnimationCurve animationCurve);

    // -(instancetype _Nonnull)initWithDelay:(NSTimeInterval)delay duration:(NSTimeInterval)duration;
    [Export ("initWithDelay:duration:")]
    IntPtr Constructor (double delay, double duration);

    // -(instancetype _Nonnull)initWithDelay:(NSTimeInterval)delay duration:(NSTimeInterval)duration animationCurve:(UIViewAnimationCurve)animationCurve;
    [Export ("initWithDelay:duration:animationCurve:")]
    IntPtr Constructor (double delay, double duration, UIViewAnimationCurve animationCurve);

    // -(instancetype _Nonnull)initWithDelay:(NSTimeInterval)delay duration:(NSTimeInterval)duration timingCurve:(id<MDMTimingCurve> _Nullable)timingCurve;
    [Export ("initWithDelay:duration:timingCurve:")]
    IntPtr Constructor (double delay, double duration, [NullAllowed] MDMTimingCurve timingCurve);

    // -(instancetype _Nonnull)initWithDelay:(NSTimeInterval)delay duration:(NSTimeInterval)duration timingCurve:(id<MDMTimingCurve> _Nullable)timingCurve repetition:(id<MDMRepetitionTraits> _Nullable)repetition __attribute__((objc_designated_initializer));
    [Export ("initWithDelay:duration:timingCurve:repetition:")]
    [DesignatedInitializer]
    IntPtr Constructor (double delay, double duration, [NullAllowed] MDMTimingCurve timingCurve, [NullAllowed] MDMRepetitionTraits repetition);

    // @property (assign, nonatomic) NSTimeInterval delay;
    [Export ("delay")]
    double Delay { get; set; }

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration")]
    double Duration { get; set; }

    // @property (nonatomic, strong) id<MDMTimingCurve> _Nullable timingCurve;
    [NullAllowed, Export ("timingCurve", ArgumentSemantic.Strong)]
    MDMTimingCurve TimingCurve { get; set; }

    // @property (nonatomic, strong) id<MDMRepetitionTraits> _Nullable repetition;
    [NullAllowed, Export ("repetition", ArgumentSemantic.Strong)]
    MDMRepetitionTraits Repetition { get; set; }
}