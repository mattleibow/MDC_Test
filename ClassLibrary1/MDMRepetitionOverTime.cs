using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMRepetitionOverTime : INSCopying, IMDMRepetitionTraits
{
    // -(instancetype _Nonnull)initWithDuration:(double)duration;
    [Export ("initWithDuration:")]
    IntPtr Constructor (double duration);

    // -(instancetype _Nonnull)initWithDuration:(double)duration autoreverses:(BOOL)autoreverses __attribute__((objc_designated_initializer));
    [Export ("initWithDuration:autoreverses:")]
    [DesignatedInitializer]
    IntPtr Constructor (double duration, bool autoreverses);

    // @property (assign, nonatomic) double duration;
    [Export ("duration")]
    double Duration { get; set; }
}