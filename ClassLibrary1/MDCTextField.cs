using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UITextField))]
interface MDCTextField : IMDCTextInput, IMDCLeadingViewTextInput
{
    // @property (readonly, nonatomic, strong) UILabel * _Nonnull inputLayoutStrut;
    [Export ("inputLayoutStrut", ArgumentSemantic.Strong)]
    UILabel InputLayoutStrut { get; }

    // @property (nonatomic, strong) UIView * _Nullable leadingView;
    [NullAllowed, Export ("leadingView", ArgumentSemantic.Strong)]
    UIView LeadingView { get; set; }

    // @property (assign, nonatomic) UITextFieldViewMode leadingViewMode;
    [Export ("leadingViewMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode LeadingViewMode { get; set; }
}