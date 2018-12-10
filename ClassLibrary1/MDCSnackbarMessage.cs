using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCSnackbarMessage : INSCopying, IUIAccessibilityIdentification
{
    // +(instancetype _Nonnull)messageWithText:(NSString * _Nonnull)text;
    [Static]
    [Export ("messageWithText:")]
    MDCSnackbarMessage MessageWithText (string text);

    // +(instancetype _Nonnull)messageWithAttributedText:(NSAttributedString * _Nonnull)attributedText;
    [Static]
    [Export ("messageWithAttributedText:")]
    MDCSnackbarMessage MessageWithAttributedText (NSAttributedString attributedText);

    // @property (assign, nonatomic, class) BOOL usesLegacySnackbar;
    [Static]
    [Export ("usesLegacySnackbar")]
    bool UsesLegacySnackbar { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable text;
    [NullAllowed, Export ("text")]
    string Text { get; set; }

    // @property (copy, nonatomic) NSAttributedString * _Nullable attributedText;
    [NullAllowed, Export ("attributedText", ArgumentSemantic.Copy)]
    NSAttributedString AttributedText { get; set; }

    // @property (nonatomic, strong) MDCSnackbarMessageAction * _Nullable action;
    [NullAllowed, Export ("action", ArgumentSemantic.Strong)]
    MDCSnackbarMessageAction Action { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonTextColor __attribute__((deprecated("Use MDCSnackbarMessageView's buttonTitleColorForState: instead.")));
    [NullAllowed, Export ("buttonTextColor", ArgumentSemantic.Strong)]
    UIColor ButtonTextColor { get; set; }

    // @property (assign, nonatomic) NSTimeInterval duration;
    [Export ("duration")]
    double Duration { get; set; }

    // @property (copy, nonatomic) MDCSnackbarMessageCompletionHandler _Nullable completionHandler;
    [NullAllowed, Export ("completionHandler", ArgumentSemantic.Copy)]
    MDCSnackbarMessageCompletionHandler CompletionHandler { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable category;
    [NullAllowed, Export ("category")]
    string Category { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
    [NullAllowed, Export ("accessibilityLabel")]
    string AccessibilityLabel { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
    [NullAllowed, Export ("accessibilityHint")]
    string AccessibilityHint { get; set; }

    // @property (readonly, nonatomic) NSString * _Nullable voiceNotificationText;
    [NullAllowed, Export ("voiceNotificationText")]
    string VoiceNotificationText { get; }
}