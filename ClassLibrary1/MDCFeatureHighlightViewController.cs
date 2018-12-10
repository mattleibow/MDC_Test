using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
[DisableDefaultCtor]
interface MDCFeatureHighlightViewController
{
    // -(instancetype _Nonnull)initWithHighlightedView:(UIView * _Nonnull)highlightedView andShowView:(UIView * _Nonnull)displayedView completion:(MDCFeatureHighlightCompletion _Nullable)completion __attribute__((objc_designated_initializer));
    [Export ("initWithHighlightedView:andShowView:completion:")]
    [DesignatedInitializer]
    IntPtr Constructor (UIView highlightedView, UIView displayedView, [NullAllowed] MDCFeatureHighlightCompletion completion);

    // -(instancetype _Nonnull)initWithHighlightedView:(UIView * _Nonnull)highlightedView completion:(MDCFeatureHighlightCompletion _Nullable)completion;
    [Export ("initWithHighlightedView:completion:")]
    IntPtr Constructor (UIView highlightedView, [NullAllowed] MDCFeatureHighlightCompletion completion);

    // @property (copy, nonatomic) NSString * _Nullable titleText;
    [NullAllowed, Export ("titleText")]
    string TitleText { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable bodyText;
    [NullAllowed, Export ("bodyText")]
    string BodyText { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified outerHighlightColor;
    [Export ("outerHighlightColor", ArgumentSemantic.Strong)]
    UIColor OuterHighlightColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified innerHighlightColor;
    [Export ("innerHighlightColor", ArgumentSemantic.Strong)]
    UIColor InnerHighlightColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable titleColor;
    [NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
    UIColor TitleColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable bodyColor;
    [NullAllowed, Export ("bodyColor", ArgumentSemantic.Strong)]
    UIColor BodyColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable titleFont;
    [NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
    UIFont TitleFont { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable bodyFont;
    [NullAllowed, Export ("bodyFont", ArgumentSemantic.Strong)]
    UIFont BodyFont { get; set; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory __attribute__((annotate("ui_appearance_selector")));
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // -(void)acceptFeature;
    [Export ("acceptFeature")]
    void AcceptFeature ();

    // -(void)rejectFeature;
    [Export ("rejectFeature")]
    void RejectFeature ();
}