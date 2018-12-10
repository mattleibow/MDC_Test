using CoreAnimation;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(CATransaction))]
interface CATransaction_MotionAnimator
{
    // +(NSNumber * _Nullable)mdm_timeScaleFactor;
    [Static]
    [NullAllowed, Export ("mdm_timeScaleFactor")]
    [Verify (MethodToProperty)]
    NSNumber Mdm_timeScaleFactor { get; }

    // +(void)mdm_setTimeScaleFactor:(NSNumber * _Nullable)timeScaleFactor;
    [Static]
    [Export ("mdm_setTimeScaleFactor:")]
    void Mdm_setTimeScaleFactor ([NullAllowed] NSNumber timeScaleFactor);
}