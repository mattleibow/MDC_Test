using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCHeaderStackView
{
    // @property (nonatomic, strong) UIView * _Nullable topBar;
    [NullAllowed, Export ("topBar", ArgumentSemantic.Strong)]
    UIView TopBar { get; set; }

    // @property (nonatomic, strong) UIView * _Nullable bottomBar;
    [NullAllowed, Export ("bottomBar", ArgumentSemantic.Strong)]
    UIView BottomBar { get; set; }
}