using System;
using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCBottomDrawerViewControllerDelegate
{
    // @required -(void)bottomDrawerControllerDidChangeTopInset:(MDCBottomDrawerViewController * _Nonnull)controller topInset:(CGFloat)topInset;
    [Abstract]
    [Export ("bottomDrawerControllerDidChangeTopInset:topInset:")]
    void TopInset (MDCBottomDrawerViewController controller, nfloat topInset);
}