using CoreAnimation;
using Foundation;
using ObjCRuntime;

[Category]
[BaseType (typeof(CAMediaTimingFunction))]
interface CAMediaTimingFunction_MDCAnimationTiming
{
    // +(CAMediaTimingFunction * _Nullable)mdc_functionWithType:(MDCAnimationTimingFunction)type;
    [Static]
    [Export ("mdc_functionWithType:")]
    [return: NullAllowed]
    CAMediaTimingFunction Mdc_functionWithType (MDCAnimationTimingFunction type);
}