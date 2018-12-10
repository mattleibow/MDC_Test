using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewCell))]
interface MDCChipCollectionViewCell
{
    // @property (readonly, nonatomic, strong) MDCChipView * _Nonnull chipView;
    [Export ("chipView", ArgumentSemantic.Strong)]
    MDCChipView ChipView { get; }

    // @property (assign, nonatomic) BOOL alwaysAnimateResize;
    [Export ("alwaysAnimateResize")]
    bool AlwaysAnimateResize { get; set; }

    // -(MDCChipView * _Nonnull)createChipView;
    [Export ("createChipView")]
    [Verify (MethodToProperty)]
    MDCChipView CreateChipView { get; }
}