using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCInkViewDelegate
{
    // @optional -(void)inkAnimationDidStart:(MDCInkView * _Nonnull)inkView;
    [Export ("inkAnimationDidStart:")]
    void InkAnimationDidStart (MDCInkView inkView);

    // @optional -(void)inkAnimationDidEnd:(MDCInkView * _Nonnull)inkView;
    [Export ("inkAnimationDidEnd:")]
    void InkAnimationDidEnd (MDCInkView inkView);
}