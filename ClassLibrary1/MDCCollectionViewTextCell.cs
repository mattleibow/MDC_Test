using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(MDCCollectionViewCell))]
interface MDCCollectionViewTextCell
{
    // @property (readonly, nonatomic, strong) UILabel * _Nullable textLabel;
    [NullAllowed, Export ("textLabel", ArgumentSemantic.Strong)]
    UILabel TextLabel { get; }

    // @property (readonly, nonatomic, strong) UILabel * _Nullable detailTextLabel;
    [NullAllowed, Export ("detailTextLabel", ArgumentSemantic.Strong)]
    UILabel DetailTextLabel { get; }

    // @property (readonly, nonatomic, strong) UIImageView * _Nullable imageView;
    [NullAllowed, Export ("imageView", ArgumentSemantic.Strong)]
    UIImageView ImageView { get; }
}