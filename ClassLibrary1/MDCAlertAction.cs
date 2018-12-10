using Foundation;
using UIKit;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCAlertAction : INSCopying, IUIAccessibilityIdentification
{
    // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title handler:(MDCActionHandler _Nullable)handler;
    [Static]
    [Export ("actionWithTitle:handler:")]
    MDCAlertAction ActionWithTitle (string title, [NullAllowed] MDCActionHandler handler);

    // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title emphasis:(MDCActionEmphasis)emphasis handler:(MDCActionHandler _Nullable)handler;
    [Static]
    [Export ("actionWithTitle:emphasis:handler:")]
    MDCAlertAction ActionWithTitle (string title, MDCActionEmphasis emphasis, [NullAllowed] MDCActionHandler handler);

    // @property (readonly, nonatomic) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; }

    // @property (readonly, nonatomic) MDCActionEmphasis emphasis;
    [Export ("emphasis")]
    MDCActionEmphasis Emphasis { get; }

    // @property (copy, nonatomic) NSString * _Nullable accessibilityIdentifier;
    [NullAllowed, Export ("accessibilityIdentifier")]
    string AccessibilityIdentifier { get; set; }
}