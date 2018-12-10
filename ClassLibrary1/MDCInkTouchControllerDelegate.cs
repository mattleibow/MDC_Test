using CoreGraphics;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCInkTouchControllerDelegate
{
    // @optional -(void)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController insertInkView:(UIView * _Nonnull)inkView intoView:(UIView * _Nonnull)view;
    [Export ("inkTouchController:insertInkView:intoView:")]
    void InkTouchController (MDCInkTouchController inkTouchController, UIView inkView, UIView view);

    // @optional -(MDCInkView * _Nullable)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController inkViewAtTouchLocation:(CGPoint)location;
    [Export ("inkTouchController:inkViewAtTouchLocation:")]
    [return: NullAllowed]
    MDCInkView InkTouchController (MDCInkTouchController inkTouchController, CGPoint location);

    // @optional -(BOOL)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController shouldProcessInkTouchesAtTouchLocation:(CGPoint)location;
    [Export ("inkTouchController:shouldProcessInkTouchesAtTouchLocation:")]
    bool InkTouchController (MDCInkTouchController inkTouchController, CGPoint location);

    // @optional -(void)inkTouchController:(MDCInkTouchController * _Nonnull)inkTouchController didProcessInkView:(MDCInkView * _Nonnull)inkView atTouchLocation:(CGPoint)location;
    [Export ("inkTouchController:didProcessInkView:atTouchLocation:")]
    void InkTouchController (MDCInkTouchController inkTouchController, MDCInkView inkView, CGPoint location);
}