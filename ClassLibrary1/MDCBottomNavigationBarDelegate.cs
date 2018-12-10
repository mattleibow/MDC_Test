using Foundation;
using UIKit;

[Protocol, Model]
interface MDCBottomNavigationBarDelegate : IUINavigationBarDelegate
{
    // @optional -(BOOL)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar shouldSelectItem:(UITabBarItem * _Nonnull)item;
    [Export ("bottomNavigationBar:shouldSelectItem:")]
    bool BottomNavigationBar (MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);

    // @optional -(void)bottomNavigationBar:(MDCBottomNavigationBar * _Nonnull)bottomNavigationBar didSelectItem:(UITabBarItem * _Nonnull)item;
    [Export ("bottomNavigationBar:didSelectItem:")]
    void BottomNavigationBar (MDCBottomNavigationBar bottomNavigationBar, UITabBarItem item);
}