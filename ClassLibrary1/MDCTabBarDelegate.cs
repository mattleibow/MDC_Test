using Foundation;
using UIKit;

[Protocol, Model]
interface MDCTabBarDelegate : IUIBarPositioningDelegate
{
    // @optional -(BOOL)tabBar:(MDCTabBar * _Nonnull)tabBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
    [Export ("tabBar:shouldSelectItem:")]
    bool TabBar (MDCTabBar tabBar, UITabBarItem item);

    // @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar willSelectItem:(UITabBarItem * _Nonnull)item;
    [Export ("tabBar:willSelectItem:")]
    void TabBar (MDCTabBar tabBar, UITabBarItem item);

    // @optional -(void)tabBar:(MDCTabBar * _Nonnull)tabBar didSelectItem:(UITabBarItem * _Nonnull)item;
    [Export ("tabBar:didSelectItem:")]
    void TabBar (MDCTabBar tabBar, UITabBarItem item);
}