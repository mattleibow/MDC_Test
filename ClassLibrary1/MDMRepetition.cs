using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMRepetition : INSCopying, IMDMRepetitionTraits
{
    // -(instancetype _Nonnull)initWithNumberOfRepetitions:(double)numberOfRepetitions;
    [Export ("initWithNumberOfRepetitions:")]
    IntPtr Constructor (double numberOfRepetitions);

    // -(instancetype _Nonnull)initWithNumberOfRepetitions:(double)numberOfRepetitions autoreverses:(BOOL)autoreverses __attribute__((objc_designated_initializer));
    [Export ("initWithNumberOfRepetitions:autoreverses:")]
    [DesignatedInitializer]
    IntPtr Constructor (double numberOfRepetitions, bool autoreverses);

    // @property (assign, nonatomic) double numberOfRepetitions;
    [Export ("numberOfRepetitions")]
    double NumberOfRepetitions { get; set; }
}