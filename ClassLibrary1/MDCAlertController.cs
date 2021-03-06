﻿using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIViewController))]
interface MDCAlertController
{
    // +(instancetype _Nonnull)alertControllerWithTitle:(NSString * _Nullable)title message:(NSString * _Nullable)message;
    [Static]
    [Export ("alertControllerWithTitle:message:")]
    MDCAlertController AlertControllerWithTitle ([NullAllowed] string title, [NullAllowed] string message);

    // @property (nonatomic, strong) UIFont * _Nullable titleFont;
    [NullAllowed, Export ("titleFont", ArgumentSemantic.Strong)]
    UIFont TitleFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable titleColor;
    [NullAllowed, Export ("titleColor", ArgumentSemantic.Strong)]
    UIColor TitleColor { get; set; }

    // @property (assign, nonatomic) NSTextAlignment titleAlignment;
    [Export ("titleAlignment", ArgumentSemantic.Assign)]
    NSTextAlignment TitleAlignment { get; set; }

    // @property (nonatomic, strong) UIImage * _Nullable titleIcon;
    [NullAllowed, Export ("titleIcon", ArgumentSemantic.Strong)]
    UIImage TitleIcon { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable titleIconTintColor;
    [NullAllowed, Export ("titleIconTintColor", ArgumentSemantic.Strong)]
    UIColor TitleIconTintColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable messageFont;
    [NullAllowed, Export ("messageFont", ArgumentSemantic.Strong)]
    UIFont MessageFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable messageColor;
    [NullAllowed, Export ("messageColor", ArgumentSemantic.Strong)]
    UIColor MessageColor { get; set; }

    // @property (nonatomic, strong) UIFont * _Nullable buttonFont;
    [NullAllowed, Export ("buttonFont", ArgumentSemantic.Strong)]
    UIFont ButtonFont { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonTitleColor;
    [NullAllowed, Export ("buttonTitleColor", ArgumentSemantic.Strong)]
    UIColor ButtonTitleColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable buttonInkColor;
    [NullAllowed, Export ("buttonInkColor", ArgumentSemantic.Strong)]
    UIColor ButtonInkColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable scrimColor;
    [NullAllowed, Export ("scrimColor", ArgumentSemantic.Strong)]
    UIColor ScrimColor { get; set; }

    // @property (assign, nonatomic) CGFloat cornerRadius;
    [Export ("cornerRadius")]
    nfloat CornerRadius { get; set; }

    // @property (assign, nonatomic) MDCShadowElevation elevation;
    [Export ("elevation")]
    double Elevation { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; set; }

    // @property (copy, nonatomic) NSString * _Nullable message;
    [NullAllowed, Export ("message")]
    string Message { get; set; }

    // @property (readwrite, nonatomic, setter = mdc_setAdjustsFontForContentSizeCategory:) BOOL mdc_adjustsFontForContentSizeCategory;
    [Export ("mdc_adjustsFontForContentSizeCategory")]
    bool Mdc_adjustsFontForContentSizeCategory { get; [Bind ("mdc_setAdjustsFontForContentSizeCategory:")] set; }

    // @property (readonly, nonatomic) NSArray<MDCAlertAction *> * _Nonnull actions;
    [Export ("actions")]
    MDCAlertAction[] Actions { get; }

    // -(void)addAction:(MDCAlertAction * _Nonnull)action;
    [Export ("addAction:")]
    void AddAction (MDCAlertAction action);
}