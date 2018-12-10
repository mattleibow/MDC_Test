using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(MDCBaseCell))]
interface MDCSelfSizingStereoCell
{
    // @property (readonly, nonatomic, strong) UIImageView * leadingImageView;
    [Export ("leadingImageView", ArgumentSemantic.Strong)]
    UIImageView LeadingImageView { get; }

    // @property (readonly, nonatomic, strong) UIImageView * trailingImageView;
    [Export ("trailingImageView", ArgumentSemantic.Strong)]
    UIImageView TrailingImageView { get; }

    // @property (readonly, nonatomic, strong) UILabel * titleLabel;
    [Export ("titleLabel", ArgumentSemantic.Strong)]
    UILabel TitleLabel { get; }

    // @property (readonly, nonatomic, strong) UILabel * detailLabel;
    [Export ("detailLabel", ArgumentSemantic.Strong)]
    UILabel DetailLabel { get; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }
}