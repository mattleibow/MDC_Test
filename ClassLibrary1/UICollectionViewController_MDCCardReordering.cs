using Foundation;
using ObjCRuntime;
using UIKit;

[Category]
[BaseType (typeof(UICollectionViewController))]
interface UICollectionViewController_MDCCardReordering : IUIGestureRecognizerDelegate
{
    // -(void)mdc_setupCardReordering;
    [Export ("mdc_setupCardReordering")]
    void Mdc_setupCardReordering ();
}