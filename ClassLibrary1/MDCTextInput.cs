using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTextInput
{
    // @required @property (copy, nonatomic) NSAttributedString * _Nullable attributedPlaceholder;
    [Abstract]
    [NullAllowed, Export ("attributedPlaceholder", ArgumentSemantic.Copy)]
    NSAttributedString AttributedPlaceholder { get; set; }

    // @required @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
    [Abstract]
    [NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
    NSAttributedString AttributedText { get; set; }

    // @required @property (copy, nonatomic) UIBezierPath * _Nullable borderPath __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [NullAllowed, Export ("borderPath", ArgumentSemantic.Copy)]
    UIBezierPath BorderPath { get; set; }

    // @required @property (nonatomic, strong) MDCTextInputBorderView * _Nullable borderView;
    [Abstract]
    [NullAllowed, Export ("borderView", ArgumentSemantic.Strong)]
    MDCTextInputBorderView BorderView { get; set; }

    // @required @property (readonly, nonatomic, strong) UIButton * _Nonnull clearButton;
    [Abstract]
    [Export ("clearButton", ArgumentSemantic.Strong)]
    UIButton ClearButton { get; }

    // @required @property (assign, nonatomic) UITextFieldViewMode clearButtonMode __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [Export ("clearButtonMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode ClearButtonMode { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Nullable cursorColor __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [NullAllowed, Export ("cursorColor", ArgumentSemantic.Strong)]
    UIColor CursorColor { get; set; }

    // @required @property (readonly, getter = isEditing, assign, nonatomic) BOOL editing;
    [Abstract]
    [Export ("editing")]
    bool Editing { [Bind ("isEditing")] get; }

    // @required @property (getter = isEnabled, assign, nonatomic) BOOL enabled;
    [Abstract]
    [Export ("enabled")]
    bool Enabled { [Bind ("isEnabled")] get; set; }

    // @required @property (nonatomic, strong) UIFont * _Nullable font;
    [Abstract]
    [NullAllowed, Export ("font", ArgumentSemantic.Strong)]
    UIFont Font { get; set; }

    // @required @property (assign, nonatomic) BOOL hidesPlaceholderOnInput;
    [Abstract]
    [Export ("hidesPlaceholderOnInput")]
    bool HidesPlaceholderOnInput { get; set; }

    // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull leadingUnderlineLabel;
    [Abstract]
    [Export ("leadingUnderlineLabel", ArgumentSemantic.Strong)]
    UILabel LeadingUnderlineLabel { get; }

    // @required @property (nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @required @property (copy, nonatomic) NSString * _Nullable placeholder;
    [Abstract]
    [NullAllowed, Export ("placeholder")]
    string Placeholder { get; set; }

    // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull placeholderLabel;
    [Abstract]
    [Export ("placeholderLabel", ArgumentSemantic.Strong)]
    UILabel PlaceholderLabel { get; }

    [Wrap ("WeakPositioningDelegate"), Abstract]
    [NullAllowed]
    MDCTextInputPositioningDelegate PositioningDelegate { get; set; }

    // @required @property (nonatomic, weak) id<MDCTextInputPositioningDelegate> _Nullable positioningDelegate;
    [Abstract]
    [NullAllowed, Export ("positioningDelegate", ArgumentSemantic.Weak)]
    NSObject WeakPositioningDelegate { get; set; }

    // @required @property (copy, nonatomic) NSString * _Nullable text;
    [Abstract]
    [NullAllowed, Export ("text")]
    string Text { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Nullable textColor;
    [Abstract]
    [NullAllowed, Export ("textColor", ArgumentSemantic.Strong)]
    UIColor TextColor { get; set; }

    // @required @property (readonly, assign, nonatomic) UIEdgeInsets textInsets;
    [Abstract]
    [Export ("textInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets TextInsets { get; }

    // @required @property (assign, nonatomic) MDCTextInputTextInsetsMode textInsetsMode __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [Export ("textInsetsMode", ArgumentSemantic.Assign)]
    MDCTextInputTextInsetsMode TextInsetsMode { get; set; }

    // @required @property (readonly, nonatomic, strong) UILabel * _Nonnull trailingUnderlineLabel;
    [Abstract]
    [Export ("trailingUnderlineLabel", ArgumentSemantic.Strong)]
    UILabel TrailingUnderlineLabel { get; }

    // @required @property (nonatomic, strong) UIView * _Nullable trailingView;
    [Abstract]
    [NullAllowed, Export ("trailingView", ArgumentSemantic.Strong)]
    UIView TrailingView { get; set; }

    // @required @property (assign, nonatomic) UITextFieldViewMode trailingViewMode;
    [Abstract]
    [Export ("trailingViewMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode TrailingViewMode { get; set; }

    // @required @property (readonly, nonatomic, strong) MDCTextInputUnderlineView * _Nullable underline;
    [Abstract]
    [NullAllowed, Export ("underline", ArgumentSemantic.Strong)]
    MDCTextInputUnderlineView Underline { get; }
}