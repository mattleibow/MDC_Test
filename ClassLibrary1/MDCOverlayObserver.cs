using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCOverlayObserver
{
    // +(instancetype)observerForScreen:(UIScreen *)screen;
    [Static]
    [Export ("observerForScreen:")]
    MDCOverlayObserver ObserverForScreen (UIScreen screen);

    // -(void)addTarget:(id)target action:(SEL)action;
    [Export ("addTarget:action:")]
    void AddTarget (NSObject target, Selector action);

    // -(void)removeTarget:(id)target action:(SEL)action;
    [Export ("removeTarget:action:")]
    void RemoveTarget (NSObject target, Selector action);

    // -(void)removeTarget:(id)target;
    [Export ("removeTarget:")]
    void RemoveTarget (NSObject target);
}