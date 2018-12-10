using System;
using CoreAnimation;
using Foundation;

[Protocol, Model]
interface MDMCoreAnimationTraceable
{
    // @required -(void)addCoreAnimationTracer:(void (^ _Nonnull)(CALayer * _Nonnull, CAAnimation * _Nonnull))tracer;
    [Abstract]
    [Export ("addCoreAnimationTracer:")]
    void AddCoreAnimationTracer (Action<CALayer, CAAnimation> tracer);
}