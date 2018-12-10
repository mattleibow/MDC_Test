using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCInkTouchController : IUIGestureRecognizerDelegate
{
    // @property (readonly, nonatomic, weak) UIView * _Nullable view;
    [NullAllowed, Export ("view", ArgumentSemantic.Weak)]
    UIView View { get; }

    // @property (readonly, nonatomic, strong) MDCInkView * _Nonnull defaultInkView;
    [Export ("defaultInkView", ArgumentSemantic.Strong)]
    MDCInkView DefaultInkView { get; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCInkTouchControllerDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCInkTouchControllerDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) BOOL delaysInkSpread;
    [Export ("delaysInkSpread")]
    bool DelaysInkSpread { get; set; }

    // @property (assign, nonatomic) CGFloat dragCancelDistance;
    [Export ("dragCancelDistance")]
    nfloat DragCancelDistance { get; set; }

    // @property (assign, nonatomic) BOOL cancelsOnDragOut;
    [Export ("cancelsOnDragOut")]
    bool CancelsOnDragOut { get; set; }

    // @property (nonatomic) CGRect targetBounds;
    [Export ("targetBounds", ArgumentSemantic.Assign)]
    CGRect TargetBounds { get; set; }

    // @property (readonly, nonatomic, strong) MDCInkGestureRecognizer * _Nonnull gestureRecognizer;
    [Export ("gestureRecognizer", ArgumentSemantic.Strong)]
    MDCInkGestureRecognizer GestureRecognizer { get; }

    // -(instancetype _Nonnull)initWithView:(UIView * _Nonnull)view __attribute__((objc_designated_initializer));
    [Export ("initWithView:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIView view);

    // -(void)addInkView;
    [Export ("addInkView")]
    void AddInkView ();

    // -(void)cancelInkTouchProcessing;
    [Export ("cancelInkTouchProcessing")]
    void CancelInkTouchProcessing ();

    // -(MDCInkView * _Nullable)inkViewAtTouchLocation:(CGPoint)location;
    [Export ("inkViewAtTouchLocation:")]
    [return: NullAllowed]
    MDCInkView InkViewAtTouchLocation (CGPoint location);
}