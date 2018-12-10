using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIPresentationController))]
interface MDCDialogPresentationController
{
    // @property (assign, nonatomic) BOOL dismissOnBackgroundTap;
    [Export ("dismissOnBackgroundTap")]
    bool DismissOnBackgroundTap { get; set; }

    // @property (assign, nonatomic) CGFloat dialogCornerRadius;
    [Export ("dialogCornerRadius")]
    nfloat DialogCornerRadius { get; set; }

    // @property (assign, nonatomic) MDCShadowElevation dialogElevation;
    [Export ("dialogElevation")]
    double DialogElevation { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
    [NullAllowed, Export ("scrimColor", ArgumentSemantic.Strong)]
    UIColor ScrimColor { get; set; }

    // -(CGSize)sizeForChildContentContainer:(id<UIContentContainer> _Nonnull)container withParentContainerSize:(CGSize)parentSize;
    [Export ("sizeForChildContentContainer:withParentContainerSize:")]
    CGSize SizeForChildContentContainer (UIContentContainer container, CGSize parentSize);

    // -(CGRect)frameOfPresentedViewInContainerView;
    [Export ("frameOfPresentedViewInContainerView")]
    [Verify (MethodToProperty)]
    CGRect FrameOfPresentedViewInContainerView { get; }
}