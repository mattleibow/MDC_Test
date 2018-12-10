using System;
using Foundation;
using UIKit;

[Protocol, Model]
interface MDCBottomDrawerPresentationControllerDelegate : IUIAdaptivePresentationControllerDelegate
{
    // @required -(void)bottomDrawerWillChangeState:(MDCBottomDrawerPresentationController * _Nonnull)presentationController drawerState:(MDCBottomDrawerState)drawerState;
    [Abstract]
    [Export ("bottomDrawerWillChangeState:drawerState:")]
    void BottomDrawerWillChangeState (MDCBottomDrawerPresentationController presentationController, MDCBottomDrawerState drawerState);

    // @required -(void)bottomDrawerTopTransitionRatio:(MDCBottomDrawerPresentationController * _Nonnull)presentationController transitionRatio:(CGFloat)transitionRatio;
    [Abstract]
    [Export ("bottomDrawerTopTransitionRatio:transitionRatio:")]
    void BottomDrawerTopTransitionRatio (MDCBottomDrawerPresentationController presentationController, nfloat transitionRatio);
}