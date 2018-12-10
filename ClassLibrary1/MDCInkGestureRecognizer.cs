using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIGestureRecognizer))]
interface MDCInkGestureRecognizer
{
    // @property (assign, nonatomic) CGFloat dragCancelDistance;
    [Export ("dragCancelDistance")]
    nfloat DragCancelDistance { get; set; }

    // @property (assign, nonatomic) BOOL cancelOnDragOut;
    [Export ("cancelOnDragOut")]
    bool CancelOnDragOut { get; set; }

    // @property (nonatomic) CGRect targetBounds;
    [Export ("targetBounds", ArgumentSemantic.Assign)]
    CGRect TargetBounds { get; set; }

    // -(CGPoint)touchStartLocationInView:(UIView *)view;
    [Export ("touchStartLocationInView:")]
    CGPoint TouchStartLocationInView (UIView view);

    // -(BOOL)isTouchWithinTargetBounds;
    [Export ("isTouchWithinTargetBounds")]
    [Verify (MethodToProperty)]
    bool IsTouchWithinTargetBounds { get; }
}