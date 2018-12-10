using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewCell))]
interface MDCBaseCell
{
    // @property (assign, nonatomic) MDCShadowElevation elevation;
    [Export ("elevation")]
    double Elevation { get; set; }

    // @property (nonatomic, strong) UIColor * _Nonnull inkColor;
    [Export ("inkColor", ArgumentSemantic.Strong)]
    UIColor InkColor { get; set; }
}