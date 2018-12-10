using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(MDCButton))]
interface MDCFloatingButton
{
    // @property (assign, nonatomic) MDCFloatingButtonMode mode;
    [Export ("mode", ArgumentSemantic.Assign)]
    MDCFloatingButtonMode Mode { get; set; }

    // @property (assign, nonatomic) MDCFloatingButtonImageLocation imageLocation __attribute__((annotate("ui_appearance_selector")));
    [Export ("imageLocation", ArgumentSemantic.Assign)]
    MDCFloatingButtonImageLocation ImageLocation { get; set; }

    // @property (assign, nonatomic) CGFloat imageTitleSpace __attribute__((annotate("ui_appearance_selector")));
    [Export ("imageTitleSpace")]
    nfloat ImageTitleSpace { get; set; }

    // +(instancetype _Nonnull)floatingButtonWithShape:(MDCFloatingButtonShape)shape;
    [Static]
    [Export ("floatingButtonWithShape:")]
    MDCFloatingButton FloatingButtonWithShape (MDCFloatingButtonShape shape);

    // +(CGFloat)defaultDimension;
    [Static]
    [Export ("defaultDimension")]
    [Verify (MethodToProperty)]
    nfloat DefaultDimension { get; }

    // +(CGFloat)miniDimension;
    [Static]
    [Export ("miniDimension")]
    [Verify (MethodToProperty)]
    nfloat MiniDimension { get; }

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame shape:(MDCFloatingButtonShape)shape __attribute__((objc_designated_initializer));
    [Export ("initWithFrame:shape:")]
    [DesignatedInitializer]
    IntPtr Constructor (CGRect frame, MDCFloatingButtonShape shape);

    // -(instancetype _Nonnull)initWithFrame:(CGRect)frame;
    [Export ("initWithFrame:")]
    IntPtr Constructor (CGRect frame);

    // -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
    [Export ("initWithCoder:")]
    [DesignatedInitializer]
    IntPtr Constructor (NSCoder aDecoder);

    // -(void)setMinimumSize:(CGSize)minimumSize forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
    [Export ("setMinimumSize:forShape:inMode:")]
    void SetMinimumSize (CGSize minimumSize, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

    // -(void)setMaximumSize:(CGSize)maximumSize forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
    [Export ("setMaximumSize:forShape:inMode:")]
    void SetMaximumSize (CGSize maximumSize, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

    // -(void)setContentEdgeInsets:(UIEdgeInsets)contentEdgeInsets forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
    [Export ("setContentEdgeInsets:forShape:inMode:")]
    void SetContentEdgeInsets (UIEdgeInsets contentEdgeInsets, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

    // -(void)setHitAreaInsets:(UIEdgeInsets)hitAreaInsets forShape:(MDCFloatingButtonShape)shape inMode:(MDCFloatingButtonMode)mode __attribute__((annotate("ui_appearance_selector")));
    [Export ("setHitAreaInsets:forShape:inMode:")]
    void SetHitAreaInsets (UIEdgeInsets hitAreaInsets, MDCFloatingButtonShape shape, MDCFloatingButtonMode mode);

    // +(instancetype _Nonnull)buttonWithShape:(MDCFloatingButtonShape)shape __attribute__((deprecated("Use floatingButtonWithShape: instead.")));
    [Static]
    [Export ("buttonWithShape:")]
    MDCFloatingButton ButtonWithShape (MDCFloatingButtonShape shape);
}