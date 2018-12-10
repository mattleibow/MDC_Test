using System;
using Foundation;

[Protocol, Model]
interface MDCBottomDrawerHeader
{
    // @optional -(void)updateDrawerHeaderTransitionRatio:(CGFloat)transitionToTopRatio;
    [Export ("updateDrawerHeaderTransitionRatio:")]
    void UpdateDrawerHeaderTransitionRatio (nfloat transitionToTopRatio);
}