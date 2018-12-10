using System;
using CoreGraphics;
using Foundation;
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

    // -(CGSize)sizeForChildContentContainer:(id<UIContentContainer> _Nonnull)container withParentContainerSize:(CGSize)parentSize;
    [Export ("sizeForChildContentContainer:withParentContainerSize:")]
    CGSize SizeForChildContentContainer (UIContentContainer container, CGSize parentSize);

    // -(CGRect)frameOfPresentedViewInContainerView;
    [Export ("frameOfPresentedViewInContainerView")]
    [Verify (MethodToProperty)]
    CGRect FrameOfPresentedViewInContainerView { get; }
}