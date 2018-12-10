using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCTextInputControllerFullWidth : IMDCTextInputController
{
    // @property (nonatomic, strong) UIColor * _Null_unspecified backgroundColor;
    [Export ("backgroundColor", ArgumentSemantic.Strong)]
    UIColor BackgroundColor { get; set; }

    // @property (nonatomic, strong, class) UIColor * _Null_unspecified backgroundColorDefault;
    [Static]
    [Export ("backgroundColorDefault", ArgumentSemantic.Strong)]
    UIColor BackgroundColorDefault { get; set; }
}