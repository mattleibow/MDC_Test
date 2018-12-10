using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCTextInputController : INSCopying, IMDCTextInputPositioningDelegate
{
    // @required @property (nonatomic, strong) UIColor * _Null_unspecified activeColor;
    [Abstract]
    [Export ("activeColor", ArgumentSemantic.Strong)]
    UIColor ActiveColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified activeColorDefault;
    [Static, Abstract]
    [Export ("activeColorDefault", ArgumentSemantic.Strong)]
    UIColor ActiveColorDefault { get; set; }

    // @required @property (nonatomic, weak) id<MDCTextInputCharacterCounter> _Null_unspecified characterCounter;
    [Abstract]
    [Export ("characterCounter", ArgumentSemantic.Weak)]
    MDCTextInputCharacterCounter CharacterCounter { get; set; }

    // @required @property (assign, nonatomic) NSUInteger characterCountMax;
    [Abstract]
    [Export ("characterCountMax")]
    nuint CharacterCountMax { get; set; }

    // @required @property (assign, nonatomic) UITextFieldViewMode characterCountViewMode;
    [Abstract]
    [Export ("characterCountViewMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode CharacterCountViewMode { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified disabledColor;
    [Abstract]
    [Export ("disabledColor", ArgumentSemantic.Strong)]
    UIColor DisabledColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified disabledColorDefault;
    [Static, Abstract]
    [Export ("disabledColorDefault", ArgumentSemantic.Strong)]
    UIColor DisabledColorDefault { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified errorColor;
    [Abstract]
    [Export ("errorColor", ArgumentSemantic.Strong)]
    UIColor ErrorColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified errorColorDefault;
    [Static, Abstract]
    [Export ("errorColorDefault", ArgumentSemantic.Strong)]
    UIColor ErrorColorDefault { get; set; }

    // @required @property (readonly, copy, nonatomic) NSString * _Nullable errorText;
    [Abstract]
    [NullAllowed, Export ("errorText")]
    string ErrorText { get; }

    // @required @property (copy, nonatomic) NSString * _Nullable helperText;
    [Abstract]
    [NullAllowed, Export ("helperText")]
    string HelperText { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified inlinePlaceholderColor;
    [Abstract]
    [Export ("inlinePlaceholderColor", ArgumentSemantic.Strong)]
    UIColor InlinePlaceholderColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified inlinePlaceholderColorDefault;
    [Static, Abstract]
    [Export ("inlinePlaceholderColorDefault", ArgumentSemantic.Strong)]
    UIColor InlinePlaceholderColorDefault { get; set; }

    // @required @property (nonatomic, strong) UIFont * _Null_unspecified textInputFont;
    [Abstract]
    [Export ("textInputFont", ArgumentSemantic.Strong)]
    UIFont TextInputFont { get; set; }

    // @required @property (nonatomic, strong, class) UIFont * _Nullable textInputFontDefault;
    [Static, Abstract]
    [NullAllowed, Export ("textInputFontDefault", ArgumentSemantic.Strong)]
    UIFont TextInputFontDefault { get; set; }

    // @required @property (nonatomic, strong) UIFont * _Null_unspecified inlinePlaceholderFont;
    [Abstract]
    [Export ("inlinePlaceholderFont", ArgumentSemantic.Strong)]
    UIFont InlinePlaceholderFont { get; set; }

    // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified inlinePlaceholderFontDefault;
    [Static, Abstract]
    [Export ("inlinePlaceholderFontDefault", ArgumentSemantic.Strong)]
    UIFont InlinePlaceholderFontDefault { get; set; }

    // @required @property (nonatomic, strong) UIFont * _Null_unspecified leadingUnderlineLabelFont;
    [Abstract]
    [Export ("leadingUnderlineLabelFont", ArgumentSemantic.Strong)]
    UIFont LeadingUnderlineLabelFont { get; set; }

    // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified leadingUnderlineLabelFontDefault;
    [Static, Abstract]
    [Export ("leadingUnderlineLabelFontDefault", ArgumentSemantic.Strong)]
    UIFont LeadingUnderlineLabelFontDefault { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified leadingUnderlineLabelTextColor;
    [Abstract]
    [Export ("leadingUnderlineLabelTextColor", ArgumentSemantic.Strong)]
    UIColor LeadingUnderlineLabelTextColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified leadingUnderlineLabelTextColorDefault;
    [Static, Abstract]
    [Export ("leadingUnderlineLabelTextColorDefault", ArgumentSemantic.Strong)]
    UIColor LeadingUnderlineLabelTextColorDefault { get; set; }

    // @required @property (assign, readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
    [Abstract]
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @required @property (assign, nonatomic, class) BOOL mdc_adjustsFontForContentSizeCategoryDefault;
    [Static, Abstract]
    [Export ("mdc_adjustsFontForContentSizeCategoryDefault")]
    bool Mdc_adjustsFontForContentSizeCategoryDefault { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified normalColor;
    [Abstract]
    [Export ("normalColor", ArgumentSemantic.Strong)]
    UIColor NormalColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Null_unspecified normalColorDefault;
    [Static, Abstract]
    [Export ("normalColorDefault", ArgumentSemantic.Strong)]
    UIColor NormalColorDefault { get; set; }

    // @required @property (copy, nonatomic) NSString * _Nullable placeholderText;
    [Abstract]
    [NullAllowed, Export ("placeholderText")]
    string PlaceholderText { get; set; }

    // @required @property (assign, nonatomic) UIRectCorner roundedCorners;
    [Abstract]
    [Export ("roundedCorners", ArgumentSemantic.Assign)]
    UIRectCorner RoundedCorners { get; set; }

    // @required @property (assign, nonatomic, class) UIRectCorner roundedCornersDefault;
    [Static, Abstract]
    [Export ("roundedCornersDefault", ArgumentSemantic.Assign)]
    UIRectCorner RoundedCornersDefault { get; set; }

    // @required @property (nonatomic, strong) UIView<MDCTextInput> * _Nullable textInput;
    [Abstract]
    [NullAllowed, Export ("textInput", ArgumentSemantic.Strong)]
    MDCTextInput TextInput { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Null_unspecified textInputClearButtonTintColor;
    [Abstract]
    [Export ("textInputClearButtonTintColor", ArgumentSemantic.Strong)]
    UIColor TextInputClearButtonTintColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Nullable textInputClearButtonTintColorDefault;
    [Static, Abstract]
    [NullAllowed, Export ("textInputClearButtonTintColorDefault", ArgumentSemantic.Strong)]
    UIColor TextInputClearButtonTintColorDefault { get; set; }

    // @required @property (nonatomic, strong) UIFont * _Null_unspecified trailingUnderlineLabelFont;
    [Abstract]
    [Export ("trailingUnderlineLabelFont", ArgumentSemantic.Strong)]
    UIFont TrailingUnderlineLabelFont { get; set; }

    // @required @property (nonatomic, strong, class) UIFont * _Null_unspecified trailingUnderlineLabelFontDefault;
    [Static, Abstract]
    [Export ("trailingUnderlineLabelFontDefault", ArgumentSemantic.Strong)]
    UIFont TrailingUnderlineLabelFontDefault { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Nullable trailingUnderlineLabelTextColor;
    [Abstract]
    [NullAllowed, Export ("trailingUnderlineLabelTextColor", ArgumentSemantic.Strong)]
    UIColor TrailingUnderlineLabelTextColor { get; set; }

    // @required @property (nonatomic, strong, class) UIColor * _Nullable trailingUnderlineLabelTextColorDefault;
    [Static, Abstract]
    [NullAllowed, Export ("trailingUnderlineLabelTextColorDefault", ArgumentSemantic.Strong)]
    UIColor TrailingUnderlineLabelTextColorDefault { get; set; }

    // @required @property (assign, nonatomic) CGFloat underlineHeightActive;
    [Abstract]
    [Export ("underlineHeightActive")]
    nfloat UnderlineHeightActive { get; set; }

    // @required @property (assign, nonatomic, class) CGFloat underlineHeightActiveDefault;
    [Static, Abstract]
    [Export ("underlineHeightActiveDefault")]
    nfloat UnderlineHeightActiveDefault { get; set; }

    // @required @property (assign, nonatomic) CGFloat underlineHeightNormal;
    [Abstract]
    [Export ("underlineHeightNormal")]
    nfloat UnderlineHeightNormal { get; set; }

    // @required @property (assign, nonatomic, class) CGFloat underlineHeightNormalDefault;
    [Static, Abstract]
    [Export ("underlineHeightNormalDefault")]
    nfloat UnderlineHeightNormalDefault { get; set; }

    // @required @property (assign, nonatomic) UITextFieldViewMode underlineViewMode;
    [Abstract]
    [Export ("underlineViewMode", ArgumentSemantic.Assign)]
    UITextFieldViewMode UnderlineViewMode { get; set; }

    // @required @property (assign, nonatomic, class) UITextFieldViewMode underlineViewModeDefault;
    [Static, Abstract]
    [Export ("underlineViewModeDefault", ArgumentSemantic.Assign)]
    UITextFieldViewMode UnderlineViewModeDefault { get; set; }

    // @required -(instancetype _Nonnull)initWithTextInput:(UIView<MDCTextInput> * _Nullable)input;
    [Abstract]
    [Export ("initWithTextInput:")]
    IntPtr Constructor ([NullAllowed] MDCTextInput input);

    // @required -(void)setErrorText:(NSString * _Nullable)errorText errorAccessibilityValue:(NSString * _Nullable)errorAccessibilityValue;
    [Abstract]
    [Export ("setErrorText:errorAccessibilityValue:")]
    void SetErrorText ([NullAllowed] string errorText, [NullAllowed] string errorAccessibilityValue);

    // @required -(void)setHelperText:(NSString * _Nullable)helperText helperAccessibilityLabel:(NSString * _Nullable)helperAccessibilityLabel;
    [Abstract]
    [Export ("setHelperText:helperAccessibilityLabel:")]
    void SetHelperText ([NullAllowed] string helperText, [NullAllowed] string helperAccessibilityLabel);
}