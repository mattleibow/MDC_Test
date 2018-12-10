using System;
using Foundation;
using UIKit;

[BaseType (typeof(NSObject))]
interface MDCKeyboardWatcher
{
    // +(instancetype)sharedKeyboardWatcher;
    [Static]
    [Export ("sharedKeyboardWatcher")]
    MDCKeyboardWatcher SharedKeyboardWatcher ();

    // +(NSTimeInterval)animationDurationFromKeyboardNotification:(NSNotification *)notification;
    [Static]
    [Export ("animationDurationFromKeyboardNotification:")]
    double AnimationDurationFromKeyboardNotification (NSNotification notification);

    // +(UIViewAnimationOptions)animationCurveOptionFromKeyboardNotification:(NSNotification *)notification;
    [Static]
    [Export ("animationCurveOptionFromKeyboardNotification:")]
    UIViewAnimationOptions AnimationCurveOptionFromKeyboardNotification (NSNotification notification);

    // @property (readonly, nonatomic) CGFloat visibleKeyboardHeight;
    [Export ("visibleKeyboardHeight")]
    nfloat VisibleKeyboardHeight { get; }

    // @property (readonly, nonatomic) CGFloat keyboardOffset __attribute__((deprecated("Use visibleKeyboardHeight instead of keyboardOffset")));
    [Export ("keyboardOffset")]
    nfloat KeyboardOffset { get; }
}