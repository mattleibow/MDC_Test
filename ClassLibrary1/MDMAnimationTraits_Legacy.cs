using System;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(MDMAnimationTraits))]
interface MDMAnimationTraits_Legacy
{
    // -(instancetype _Nonnull)initWithMotionTiming:(MDMMotionTiming)timing;
    [Export ("initWithMotionTiming:")]
    IntPtr Constructor (MDMMotionTiming timing);
}