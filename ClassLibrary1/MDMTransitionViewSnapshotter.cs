using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDMTransitionViewSnapshotter
{
    // -(instancetype _Nonnull)initWithContainerView:(UIView * _Nonnull)containerView __attribute__((objc_designated_initializer));
    [Export ("initWithContainerView:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIView containerView);

    // -(UIView * _Nonnull)snapshotOfView:(UIView * _Nonnull)view isAppearing:(BOOL)isAppearing;
    [Export ("snapshotOfView:isAppearing:")]
    UIView SnapshotOfView (UIView view, bool isAppearing);

    // -(void)removeAllSnapshots;
    [Export ("removeAllSnapshots")]
    void RemoveAllSnapshots ();
}