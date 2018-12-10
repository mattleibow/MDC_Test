using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCActivityIndicatorTransition
{
    // @property (copy, nonatomic) MDCActivityIndicatorAnimation _Nonnull animation;
    [Export ("animation", ArgumentSemantic.Copy)]
    MDCActivityIndicatorAnimation Animation { get; set; }

    // @property (copy, nonatomic) void (^ _Nullable)(void) completion;
    [NullAllowed, Export ("completion", ArgumentSemantic.Copy)]
    Action Completion { get; set; }

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration")]
    double Duration { get; set; }

    // -(instancetype _Nonnull)initWithAnimation:(MDCActivityIndicatorAnimation _Nonnull)animation __attribute__((objc_designated_initializer));
    [Export ("initWithAnimation:")]
    [DesignatedInitializer]
    IntPtr Constructor (MDCActivityIndicatorAnimation animation);
}