using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
interface MDCLeadingViewTextInput : IMDCTextInput
{
    // @required @property (nonatomic, strong) UIView * _Nullable leadingView;
    [Abstract]
    [NullAllowed, Export ("leadingView", ArgumentSemantic.Strong)]
    UIView LeadingView { get; set; }

    // @required @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
    [Abstract]
    [Export ("leadingViewMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode LeadingViewMode { get; set; }
}