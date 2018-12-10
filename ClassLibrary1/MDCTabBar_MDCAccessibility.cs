using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(MDCTabBar))]
interface MDCTabBar_MDCAccessibility
{
    // -(id _Nullable)accessibilityElementForItem:(UITabBarItem * _Nonnull)item;
    [Export ("accessibilityElementForItem:")]
    [return: NullAllowed]
    NSObject AccessibilityElementForItem (UITabBarItem item);
}