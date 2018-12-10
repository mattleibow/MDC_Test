using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

// @interface MDCAnimationTiming (CAMediaTimingFunction)

// @protocol MDMTimingCurve <NSObject, NSCopying>

// @interface  (CAMediaTimingFunction) <MDMTimingCurve>

// @interface MotionInterchangeExtension (CAMediaTimingFunction)

// @interface MotionAnimator (CATransaction)

// @interface MDCActivityIndicator : UIView

// @protocol MDCActivityIndicatorDelegate <NSObject>

// typedef void (^MDCActivityIndicatorAnimation)(CGFloat, CGFloat);

// @interface MDCActivityIndicatorTransition : NSObject

// @protocol MDCColorScheme <NSObject>

// @interface MDCBasicColorScheme : NSObject <MDCColorScheme, NSCopying>

// @interface MDCTonalColorScheme : NSObject <MDCColorScheme, NSCopying>

// @interface MDCTonalPalette : NSObject <NSCopying>

// @protocol MDCColorScheming

// @interface MDCSemanticColorScheme : NSObject <MDCColorScheming>

// @interface MDCActivityIndicatorColorThemer : NSObject

// @interface ToBeDeprecated (MDCActivityIndicatorColorThemer)

// @interface MDCInkGestureRecognizer : UIGestureRecognizer

// @interface MDCInkTouchController : NSObject <UIGestureRecognizerDelegate>

// @protocol MDCInkTouchControllerDelegate <NSObject>

// typedef void (^MDCInkCompletionBlock)();

// @interface MDCInkView : UIView

// @protocol MDCInkViewDelegate <NSObject>

// @interface MDCCornerTreatment : NSObject <NSCopying>

// @interface MDCEdgeTreatment : NSObject <NSCopying>

// @interface MDCPathGenerator : NSObject

// @protocol MDCShapeGenerating <NSCopying>

// @interface MDCRectangleShapeGenerator : NSObject <MDCShapeGenerating>

// @interface MDCShadowMetrics : NSObject

// @interface MDCShadowLayer : CALayer

// @interface Subclassing (MDCShadowLayer) <CALayerDelegate>

// @interface MDCShapedShadowLayer : MDCShadowLayer

// @interface MDCShapedView : UIView

// @interface MDCButton : UIButton

// @interface MDCFlatButton : MDCButton

// @interface MDCFloatingButton : MDCButton

// @interface Animation (MDCFloatingButton)

// @interface MDCRaisedButton : MDCButton

// @interface MDCAlertController : UIViewController

// typedef void (^MDCActionHandler)(MDCAlertAction * _Nonnull);

// @interface MDCAlertAction : NSObject <NSCopying, UIAccessibilityIdentification>

// @interface MDCAlertControllerView : UIView

// @interface MDCDialogPresentationController : UIPresentationController

// @interface MDCDialogTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>

// @interface MaterialDialogs (UIViewController)

// @interface MDCAlertColorThemer : NSObject

// @interface ToBeDeprecated (MDCAlertColorThemer)

// @interface ButtonForAction (MDCAlertController)

// @interface MDCShapeCategory : NSObject

// @protocol MDCShapeScheming

// @interface MDCShapeScheme : NSObject <MDCShapeScheming>

// @protocol MDCFontScheme <NSObject>

// @interface MDCBasicFontScheme : NSObject <MDCFontScheme>

// @protocol MDCTypographyScheming

// @interface MDCTypographyScheme : NSObject <MDCTypographyScheming>

// @protocol MDCButtonScheming

// @interface MDCButtonScheme : NSObject <MDCButtonScheming>

// @interface MDCContainedButtonThemer : NSObject

// @interface MDCFloatingActionButtonThemer : NSObject

// @interface MDCTextButtonThemer : NSObject

// @interface MDCOutlinedButtonThemer : NSObject

// @protocol MDCAlertScheming

// @interface MDCAlertScheme : NSObject <MDCAlertScheming>

// @interface MDCAlertControllerThemer : NSObject

// @interface MDCAlertTypographyThemer : NSObject

// @interface MDCFlexibleHeaderContainerViewController : UIViewController

// typedef void (^MDCFlexibleHeaderChangeContentInsetsBlock)();

// typedef void (^MDCFlexibleHeaderShadowIntensityChangeBlock)(CALayer * _Nonnull, CGFloat);

// @interface MDCFlexibleHeaderView : UIView

// @protocol MDCFlexibleHeaderViewDelegate <NSObject>

// @interface  (MDCFlexibleHeaderView)

// @interface  (MDCFlexibleHeaderView)
[Category]
[BaseType (typeof(MDCFlexibleHeaderView))]
interface MDCFlexibleHeaderView_
{
	// @property (nonatomic) MDCFlexibleHeaderShiftBehavior shiftBehavior;
	[Export ("shiftBehavior", ArgumentSemantic.Assign)]
	MDCFlexibleHeaderShiftBehavior ShiftBehavior { get; set; }

	// @property (nonatomic) MDCFlexibleHeaderContentImportance headerContentImportance;
	[Export ("headerContentImportance", ArgumentSemantic.Assign)]
	MDCFlexibleHeaderContentImportance HeaderContentImportance { get; set; }

	// @property (nonatomic) BOOL trackingScrollViewIsBeingScrubbed;
	[Export ("trackingScrollViewIsBeingScrubbed")]
	bool TrackingScrollViewIsBeingScrubbed { get; set; }

	// @property (nonatomic) BOOL contentIsTranslucent;
	[Export ("contentIsTranslucent")]
	bool ContentIsTranslucent { get; set; }

	// @property (nonatomic) BOOL statusBarHintCanOverlapHeader;
	[Export ("statusBarHintCanOverlapHeader")]
	bool StatusBarHintCanOverlapHeader { get; set; }

	// -(void)hideViewWhenShifted:(UIView * _Nonnull)view;
	[Export ("hideViewWhenShifted:")]
	void HideViewWhenShifted (UIView view);

	// -(void)stopHidingViewWhenShifted:(UIView * _Nonnull)view;
	[Export ("stopHidingViewWhenShifted:")]
	void StopHidingViewWhenShifted (UIView view);

	// -(void)shiftHeaderOnScreenAnimated:(BOOL)animated;
	[Export ("shiftHeaderOnScreenAnimated:")]
	void ShiftHeaderOnScreenAnimated (bool animated);

	// -(void)shiftHeaderOffScreenAnimated:(BOOL)animated;
	[Export ("shiftHeaderOffScreenAnimated:")]
	void ShiftHeaderOffScreenAnimated (bool animated);

	// -(void)trackingScrollViewDidEndDraggingWillDecelerate:(BOOL)willDecelerate;
	[Export ("trackingScrollViewDidEndDraggingWillDecelerate:")]
	void TrackingScrollViewDidEndDraggingWillDecelerate (bool willDecelerate);

	// -(void)trackingScrollViewDidEndDecelerating;
	[Export ("trackingScrollViewDidEndDecelerating")]
	void TrackingScrollViewDidEndDecelerating ();

	// -(BOOL)trackingScrollViewWillEndDraggingWithVelocity:(CGPoint)velocity targetContentOffset:(CGPoint * _Nonnull)targetContentOffset;
	[Export ("trackingScrollViewWillEndDraggingWithVelocity:targetContentOffset:")]
	unsafe bool TrackingScrollViewWillEndDraggingWithVelocity (CGPoint velocity, CGPoint* targetContentOffset);
}

// @interface  (MDCFlexibleHeaderView)
[Category]
[BaseType (typeof(MDCFlexibleHeaderView))]
interface MDCFlexibleHeaderView_
{
	// @property (nonatomic) MDCFlexibleHeaderShiftBehavior behavior __attribute__((deprecated("Use shiftBehavior instead.")));
	[Export ("behavior", ArgumentSemantic.Assign)]
	MDCFlexibleHeaderShiftBehavior Behavior { get; set; }
}

// @interface MDCFlexibleHeaderViewController : UIViewController <UIScrollViewDelegate, UITableViewDelegate>

// @protocol MDCFlexibleHeaderViewLayoutDelegate <NSObject>

// @interface ToBeDeprecated (MDCFlexibleHeaderViewController)

// @interface MDCHeaderStackView : UIView

// @protocol MDCUINavigationItemObservables <NSObject>

// @interface MDCNavigationBarTextColorAccessibilityMutator : NSObject

// @interface MDCNavigationBar : UIView

// @interface MDCAppBarViewController : MDCFlexibleHeaderViewController

// @interface MDCAppBar : NSObject

// @interface MDCAppBarContainerViewController : UIViewController

// @protocol MDCAppBarNavigationControllerDelegate <UINavigationControllerDelegate>

// @interface MDCAppBarNavigationController : UINavigationController

// @interface ToBeDeprecated (MDCAppBarNavigationController)

// @interface MDCAppBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCAppBarColorThemer)

// @interface MDCAppBarTypographyThemer : NSObject

// @interface ToBeDeprecated (MDCAppBarTypographyThemer)

// @interface MDCBaseCell : UICollectionViewCell

// @interface MDCBottomAppBarView : UIView

// @interface MDCBottomAppBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCBottomAppBarColorThemer)

// @protocol MDCBottomDrawerHeader

// @protocol MDCBottomDrawerPresentationControllerDelegate <UIAdaptivePresentationControllerDelegate>

// @interface MDCBottomDrawerPresentationController : UIPresentationController

// @interface MDCBottomDrawerViewController : UIViewController <MDCBottomDrawerPresentationControllerDelegate>

// @protocol MDCBottomDrawerViewControllerDelegate <NSObject>

// @interface MDCBottomDrawerTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>

// @interface MDCBottomDrawerColorThemer : NSObject

// @interface MDCBottomNavigationBar : UIView

// @protocol MDCBottomNavigationBarDelegate <UINavigationBarDelegate>

// @interface MDCBottomNavigationBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCBottomNavigationBarColorThemer)

// @interface MDCBottomNavigationBarTypographyThemer : NSObject

// @interface MDCBottomSheetController : UIViewController

// @protocol MDCBottomSheetControllerDelegate <NSObject>

// @protocol MDCBottomSheetPresentationControllerDelegate <UIAdaptivePresentationControllerDelegate>

// @interface MDCBottomSheetPresentationController : UIPresentationController

// @interface MDCBottomSheetTransitionController : NSObject <UIViewControllerAnimatedTransitioning, UIViewControllerTransitioningDelegate>

// @interface ScrimAccessibility (MDCBottomSheetTransitionController)

// @interface MaterialBottomSheet (UIViewController)

// @interface MDCCurvedCornerTreatment : MDCCornerTreatment

// @interface MDCCutCornerTreatment : MDCCornerTreatment

// @interface MDCRoundedCornerTreatment : MDCCornerTreatment

// @interface CornerTypeInitalizer (MDCCornerTreatment)

// @interface MDCCurvedRectShapeGenerator : NSObject <MDCShapeGenerating>

// @interface MDCPillShapeGenerator : NSObject <MDCShapeGenerating>

// @interface MDCSlantedRectShapeGenerator : NSObject <MDCShapeGenerating>

// @interface MDCTriangleEdgeTreatment : MDCEdgeTreatment

// @interface MDCBottomSheetControllerShapeThemer : NSObject

// @interface MDCButtonBar : UIView

// @protocol MDCButtonBarDelegate <NSObject>

// @interface MDCButtonBarButton : MDCFlatButton

// @interface MDCButtonBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCButtonBarColorThemer)

// @interface MDCButtonBarTypographyThemer : NSObject

// @interface MDCButtonColorThemer : NSObject

// @interface ToBeDeprecated (MDCButtonColorThemer)

// @interface MDCButtonShapeThemer : NSObject

// @interface MDCButtonTitleColorAccessibilityMutator : NSObject

// @interface MDCButtonTypographyThemer : NSObject

// @interface MDCCard : UIControl

// @interface MDCCardCollectionCell : UICollectionViewCell

// @protocol MDCCardScheming

// @interface MDCCardScheme : NSObject <MDCCardScheming>

// @interface MDCCardThemer : NSObject

// @interface MDCCardsColorThemer : NSObject

// @interface MDCCardsShapeThemer : NSObject

// @interface MDCChipCollectionViewCell : UICollectionViewCell

// @interface MDCChipCollectionViewFlowLayout : UICollectionViewFlowLayout

// @interface MDCChipView : UIControl

// @interface MDCIntrinsicHeightTextView : UITextView

// @protocol MDCTextInput <NSObject>

// @protocol MDCLeadingViewTextInput <MDCTextInput>

// @protocol MDCMultilineTextInput <MDCTextInput>

// @interface MDCMultilineTextField : UIView <MDCTextInput, MDCMultilineTextInput>

// @protocol MDCMultilineTextInputLayoutDelegate <NSObject>

// @protocol MDCMultilineTextInputDelegate <NSObject>

// @interface MDCTextField : UITextField <MDCTextInput, MDCLeadingViewTextInput>

// @protocol MDCTextInputPositioningDelegate <NSObject>

// @protocol MDCTextInputCharacterCounter <NSObject>

// @interface MDCTextInputAllCharactersCounter : NSObject <MDCTextInputCharacterCounter>

// @protocol MDCTextInputController <NSObject, NSCopying, MDCTextInputPositioningDelegate>

// @protocol MDCTextInputControllerFloatingPlaceholder <MDCTextInputController>

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MDCTextInputControllerBaseDefaultBorderRadius;
	[Field ("MDCTextInputControllerBaseDefaultBorderRadius", "__Internal")]
	nfloat MDCTextInputControllerBaseDefaultBorderRadius { get; }
}

// @interface MDCTextInputControllerBase : NSObject <MDCTextInputControllerFloatingPlaceholder>

// @interface MDCTextInputControllerFilled : MDCTextInputControllerBase

// @interface MDCTextInputControllerFullWidth : NSObject <MDCTextInputController>

// @interface MDCTextInputControllerLegacyDefault : MDCTextInputControllerBase

// @interface MDCTextInputControllerLegacyFullWidth : MDCTextInputControllerFullWidth

// @interface MDCTextInputControllerOutlined : MDCTextInputControllerBase

// @interface MDCTextInputControllerOutlinedTextArea : MDCTextInputControllerBase

// @interface MDCTextInputControllerUnderline : MDCTextInputControllerBase

// @interface MDCTextInputUnderlineView : UIView <NSCopying>

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MDCChipFieldDefaultMinTextFieldWidth;
	[Field ("MDCChipFieldDefaultMinTextFieldWidth", "__Internal")]
	nfloat MDCChipFieldDefaultMinTextFieldWidth { get; }

	// extern const UIEdgeInsets MDCChipFieldDefaultContentEdgeInsets;
	[Field ("MDCChipFieldDefaultContentEdgeInsets", "__Internal")]
	UIEdgeInsets MDCChipFieldDefaultContentEdgeInsets { get; }
}

// @interface MDCChipField : UIView

// @protocol MDCChipFieldDelegate <NSObject>

// @interface MDCChipViewColorThemer : NSObject

// @interface ToBeDeprecated (MDCChipViewColorThemer)

// @interface MDCChipViewFontThemer : NSObject

// @protocol MDCChipViewScheming

// @interface MDCChipViewScheme : NSObject <MDCChipViewScheming>

// @interface MDCChipViewShapeThemer : NSObject

// @interface MDCChipViewThemer : NSObject

// @interface MDCChipViewTypographyThemer : NSObject

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const _Nonnull kSelectedCellAccessibilityHintKey;
	[Field ("kSelectedCellAccessibilityHintKey", "__Internal")]
	NSString kSelectedCellAccessibilityHintKey { get; }

	// extern NSString *const _Nonnull kDeselectedCellAccessibilityHintKey;
	[Field ("kDeselectedCellAccessibilityHintKey", "__Internal")]
	NSString kDeselectedCellAccessibilityHintKey { get; }
}

// @interface MDCCollectionViewCell : UICollectionViewCell

// @protocol MDCCollectionViewEditingDelegate <NSObject>

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MDCCollectionViewCellStyleCardSectionInset;
	[Field ("MDCCollectionViewCellStyleCardSectionInset", "__Internal")]
	nfloat MDCCollectionViewCellStyleCardSectionInset { get; }
}

// @protocol MDCCollectionViewStyling <NSObject>

// @protocol MDCCollectionViewStylingDelegate <NSObject>

// @interface MDCCollectionViewController : UICollectionViewController <MDCCollectionViewEditingDelegate, MDCCollectionViewStylingDelegate, UICollectionViewDelegateFlowLayout>

// @protocol MDCCollectionViewEditing <NSObject>

// @interface MDCCollectionViewFlowLayout : UICollectionViewFlowLayout

// @interface MDCCollectionViewLayoutAttributes : UICollectionViewLayoutAttributes <NSCopying>

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MDCCellDefaultOneLineHeight;
	[Field ("MDCCellDefaultOneLineHeight", "__Internal")]
	nfloat MDCCellDefaultOneLineHeight { get; }

	// extern const CGFloat MDCCellDefaultOneLineWithAvatarHeight;
	[Field ("MDCCellDefaultOneLineWithAvatarHeight", "__Internal")]
	nfloat MDCCellDefaultOneLineWithAvatarHeight { get; }

	// extern const CGFloat MDCCellDefaultTwoLineHeight;
	[Field ("MDCCellDefaultTwoLineHeight", "__Internal")]
	nfloat MDCCellDefaultTwoLineHeight { get; }

	// extern const CGFloat MDCCellDefaultThreeLineHeight;
	[Field ("MDCCellDefaultThreeLineHeight", "__Internal")]
	nfloat MDCCellDefaultThreeLineHeight { get; }
}

// @interface MDCCollectionViewTextCell : MDCCollectionViewCell

// @interface MDCContainedButtonColorThemer : NSObject

// @interface MDFTextAccessibility : NSObject

// @interface MDCFeatureHighlightAccessibilityMutator : NSObject

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat kMDCFeatureHighlightOuterHighlightAlpha;
	[Field ("kMDCFeatureHighlightOuterHighlightAlpha", "__Internal")]
	nfloat kMDCFeatureHighlightOuterHighlightAlpha { get; }
}

// typedef void (^MDCFeatureHighlightCompletion)(BOOL);

// @interface MDCFeatureHighlightViewController : UIViewController

// @interface MDCFeatureHighlightView : UIView

// @interface MDCFeatureHighlightColorThemer : NSObject

// @interface ToBeDeprecated (MDCFeatureHighlightColorThemer)

// @interface MDCFeatureHighlightFontThemer : NSObject

// @interface MDCFeatureHighlightTypographyThemer : NSObject

// @interface MDCFilledTextFieldColorThemer : NSObject

// @interface MDCFlexibleHeaderColorThemer : NSObject

// @interface ToBeDeprecated (MDCFlexibleHeaderColorThemer)

// @interface  (MDCFlexibleHeaderView)
[Category]
[BaseType (typeof(MDCFlexibleHeaderView))]
interface MDCFlexibleHeaderView_
{
	// @property (nonatomic) BOOL canAlwaysExpandToMaximumHeight;
	[Export ("canAlwaysExpandToMaximumHeight")]
	bool CanAlwaysExpandToMaximumHeight { get; set; }
}

// @interface MDCFloatingButtonColorThemer : NSObject

// @interface MDCFloatingButtonShapeThemer : NSObject

// @interface MDCHeaderStackViewColorThemer : NSObject

// @interface ToBeDeprecated (MDCHeaderStackViewColorThemer)

// @interface MDCIcons : NSObject

// @interface BundleLoader (MDCIcons)

// @interface MDCInkColorThemer : NSObject

// @interface ToBeDeprecated (MDCInkColorThemer)

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern NSString *const MDCKeyboardWatcherKeyboardWillShowNotification;
	[Field ("MDCKeyboardWatcherKeyboardWillShowNotification", "__Internal")]
	NSString MDCKeyboardWatcherKeyboardWillShowNotification { get; }

	// extern NSString *const MDCKeyboardWatcherKeyboardWillHideNotification;
	[Field ("MDCKeyboardWatcherKeyboardWillHideNotification", "__Internal")]
	NSString MDCKeyboardWatcherKeyboardWillHideNotification { get; }

	// extern NSString *const MDCKeyboardWatcherKeyboardWillChangeFrameNotification;
	[Field ("MDCKeyboardWatcherKeyboardWillChangeFrameNotification", "__Internal")]
	NSString MDCKeyboardWatcherKeyboardWillChangeFrameNotification { get; }
}

// @interface MDCKeyboardWatcher : NSObject

// @interface MDCLibraryInfo : NSObject

// @interface MDCSelfSizingStereoCell : MDCBaseCell

// @interface MDCListColorThemer : NSObject

// @protocol MDCListScheming

// @interface MDCListScheme : NSObject <MDCListScheming>

// @interface MDCListThemer : NSObject

// @interface MDCListTypographyThemer : NSObject

// @interface MDCMaskedTransitionController : NSObject <UIViewControllerTransitioningDelegate>

// @interface MDCNavigationBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCNavigationBarColorThemer)

// @interface MDCNavigationBarTypographyThemer : NSObject

// @interface MDCNumericValueLabel : UIView

// @interface MDCOutlinedButtonColorThemer : NSObject

// @interface MDCOutlinedTextFieldColorThemer : NSObject

// @interface MDCOverlayObserver : NSObject

// @protocol MDCOverlay <NSObject>

// @protocol MDCOverlayTransitioning <NSObject>

// @interface MDCOverlayWindow : UIWindow

// @interface MDCPageControl : UIControl <UIScrollViewDelegate>

// @interface MDCPageControlColorThemer : NSObject

// @interface ToBeDeprecated (MDCPageControlColorThemer)

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint50Name;
	[Field ("MDCPaletteTint50Name", "__Internal")]
	NSString MDCPaletteTint50Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint100Name;
	[Field ("MDCPaletteTint100Name", "__Internal")]
	NSString MDCPaletteTint100Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint200Name;
	[Field ("MDCPaletteTint200Name", "__Internal")]
	NSString MDCPaletteTint200Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint300Name;
	[Field ("MDCPaletteTint300Name", "__Internal")]
	NSString MDCPaletteTint300Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint400Name;
	[Field ("MDCPaletteTint400Name", "__Internal")]
	NSString MDCPaletteTint400Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint500Name;
	[Field ("MDCPaletteTint500Name", "__Internal")]
	NSString MDCPaletteTint500Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint600Name;
	[Field ("MDCPaletteTint600Name", "__Internal")]
	NSString MDCPaletteTint600Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint700Name;
	[Field ("MDCPaletteTint700Name", "__Internal")]
	NSString MDCPaletteTint700Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint800Name;
	[Field ("MDCPaletteTint800Name", "__Internal")]
	NSString MDCPaletteTint800Name { get; }

	// extern MDCPaletteTint  _Nonnull const MDCPaletteTint900Name;
	[Field ("MDCPaletteTint900Name", "__Internal")]
	NSString MDCPaletteTint900Name { get; }

	// extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent100Name;
	[Field ("MDCPaletteAccent100Name", "__Internal")]
	NSString MDCPaletteAccent100Name { get; }

	// extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent200Name;
	[Field ("MDCPaletteAccent200Name", "__Internal")]
	NSString MDCPaletteAccent200Name { get; }

	// extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent400Name;
	[Field ("MDCPaletteAccent400Name", "__Internal")]
	NSString MDCPaletteAccent400Name { get; }

	// extern MDCPaletteAccent  _Nonnull const MDCPaletteAccent700Name;
	[Field ("MDCPaletteAccent700Name", "__Internal")]
	NSString MDCPaletteAccent700Name { get; }
}

// @interface MDCPalette : NSObject

// @interface MDCProgressView : UIView

// @interface MDCProgressViewColorThemer : NSObject

// @interface ToBeDeprecated (MDCProgressViewColorThemer)

// @interface MDCSlider : UIControl

// @protocol MDCSliderDelegate <NSObject>

// @interface MDCSliderColorThemer : NSObject

// @interface ToBeDeprecated (MDCSliderColorThemer)

// @protocol MDCSnackbarManagerDelegate <NSObject>

// @interface MDCSnackbarManager : NSObject

// @protocol MDCSnackbarSuspensionToken <NSObject>

// @interface LegacyAPI (MDCSnackbarManager)

// typedef void (^MDCSnackbarMessageCompletionHandler)(BOOL);

// typedef void (^MDCSnackbarMessageActionHandler)();

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const NSTimeInterval MDCSnackbarMessageDurationMax;
	[Field ("MDCSnackbarMessageDurationMax", "__Internal")]
	double MDCSnackbarMessageDurationMax { get; }

	// extern NSString *const _Nonnull MDCSnackbarMessageBoldAttributeName;
	[Field ("MDCSnackbarMessageBoldAttributeName", "__Internal")]
	NSString MDCSnackbarMessageBoldAttributeName { get; }
}

// @interface MDCSnackbarMessage : NSObject <NSCopying, UIAccessibilityIdentification>

// @interface MDCSnackbarMessageAction : NSObject <UIAccessibilityIdentification, NSCopying>

// @interface MDCSnackbarMessageView : UIView

// @interface  (MDCSnackbarMessageView)

// @interface MDCSnackbarColorThemer : NSObject

// @interface Deprecated (MDCSnackbarColorThemer)

// @interface MDCSnackbarFontThemer : NSObject

// @interface MDCSnackbarTypographyThemer : NSObject

// @interface MDCTabBar : UIView <UIBarPositioning>

// @interface MDCAccessibility (MDCTabBar)

// @protocol MDCTabBarDelegate <UIBarPositioningDelegate>

// @interface MDCTabBarIndicatorAttributes : NSObject <NSCopying>

// @protocol MDCTabBarIndicatorContext <NSObject>

// @protocol MDCTabBarIndicatorTemplate <NSObject>

// @interface MDCTabBarUnderlineIndicatorTemplate : NSObject <MDCTabBarIndicatorTemplate>

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern const CGFloat MDCTabBarViewControllerAnimationDuration;
	[Field ("MDCTabBarViewControllerAnimationDuration", "__Internal")]
	nfloat MDCTabBarViewControllerAnimationDuration { get; }
}

// @interface MDCTabBarViewController : UIViewController <MDCTabBarDelegate, UIBarPositioningDelegate>

// @protocol MDCTabBarControllerDelegate <NSObject>

// @interface MDCTabBarColorThemer : NSObject

// @interface ToBeDeprecated (MDCTabBarColorThemer)

// @interface MDCTabBarFontThemer : NSObject

// @interface MDCTabBarTypographyThemer : NSObject

// @interface MDCTextButtonColorThemer : NSObject

// @interface MDCTextFieldColorThemer : NSObject

// @interface ToBeDeprecated (MDCTextFieldColorThemer)

// @interface MDCTextFieldFontThemer : NSObject

// @interface MDCTextFieldTypographyThemer : NSObject

// @interface MDCTextInputBorderView : UIView <NSCopying>

// @interface MDCThumbTrack : UIControl

// @protocol MDCThumbTrackDelegate <NSObject>

// @interface MDCThumbView : UIView

// @protocol MDCTypographyFontLoading <NSObject>

// @interface MDCTypography : NSObject

// @interface MDCSystemFontLoader : NSObject <MDCTypographyFontLoading>

// @interface MaterialRTL (NSLocale)

// @interface MaterialBidi (NSString)

// @interface MaterialRTL (UIImage)

// @interface MaterialRTL (UIView)

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double MDFInternationalizationVersionNumber;
	[Field ("MDFInternationalizationVersionNumber", "__Internal")]
	double MDFInternationalizationVersionNumber { get; }

	// extern const unsigned char [] MDFInternationalizationVersionString;
	[Field ("MDFInternationalizationVersionString", "__Internal")]
	byte[] MDFInternationalizationVersionString { get; }

	// extern double MDFInternationalizationVersionNumber;
	[Field ("MDFInternationalizationVersionNumber", "__Internal")]
	double MDFInternationalizationVersionNumber { get; }

	// extern const unsigned char [] MDFInternationalizationVersionString;
	[Field ("MDFInternationalizationVersionString", "__Internal")]
	byte[] MDFInternationalizationVersionString { get; }

	// extern double MDFTextAccessibilityVersionNumber;
	[Field ("MDFTextAccessibilityVersionNumber", "__Internal")]
	double MDFTextAccessibilityVersionNumber { get; }

	// extern const unsigned char [] MDFTextAccessibilityVersionString;
	[Field ("MDFTextAccessibilityVersionString", "__Internal")]
	byte[] MDFTextAccessibilityVersionString { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathAnchorPoint;
	[Field ("MDMKeyPathAnchorPoint", "__Internal")]
	NSString MDMKeyPathAnchorPoint { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathBackgroundColor;
	[Field ("MDMKeyPathBackgroundColor", "__Internal")]
	NSString MDMKeyPathBackgroundColor { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathBounds;
	[Field ("MDMKeyPathBounds", "__Internal")]
	NSString MDMKeyPathBounds { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathBorderWidth;
	[Field ("MDMKeyPathBorderWidth", "__Internal")]
	NSString MDMKeyPathBorderWidth { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathBorderColor;
	[Field ("MDMKeyPathBorderColor", "__Internal")]
	NSString MDMKeyPathBorderColor { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathCornerRadius;
	[Field ("MDMKeyPathCornerRadius", "__Internal")]
	NSString MDMKeyPathCornerRadius { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathHeight;
	[Field ("MDMKeyPathHeight", "__Internal")]
	NSString MDMKeyPathHeight { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathOpacity;
	[Field ("MDMKeyPathOpacity", "__Internal")]
	NSString MDMKeyPathOpacity { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathPosition;
	[Field ("MDMKeyPathPosition", "__Internal")]
	NSString MDMKeyPathPosition { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathRotation;
	[Field ("MDMKeyPathRotation", "__Internal")]
	NSString MDMKeyPathRotation { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathScale;
	[Field ("MDMKeyPathScale", "__Internal")]
	NSString MDMKeyPathScale { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathShadowColor;
	[Field ("MDMKeyPathShadowColor", "__Internal")]
	NSString MDMKeyPathShadowColor { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathShadowOffset;
	[Field ("MDMKeyPathShadowOffset", "__Internal")]
	NSString MDMKeyPathShadowOffset { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathShadowOpacity;
	[Field ("MDMKeyPathShadowOpacity", "__Internal")]
	NSString MDMKeyPathShadowOpacity { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathShadowRadius;
	[Field ("MDMKeyPathShadowRadius", "__Internal")]
	NSString MDMKeyPathShadowRadius { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathStrokeStart;
	[Field ("MDMKeyPathStrokeStart", "__Internal")]
	NSString MDMKeyPathStrokeStart { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathStrokeEnd;
	[Field ("MDMKeyPathStrokeEnd", "__Internal")]
	NSString MDMKeyPathStrokeEnd { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathTransform;
	[Field ("MDMKeyPathTransform", "__Internal")]
	NSString MDMKeyPathTransform { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathWidth;
	[Field ("MDMKeyPathWidth", "__Internal")]
	NSString MDMKeyPathWidth { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathX;
	[Field ("MDMKeyPathX", "__Internal")]
	NSString MDMKeyPathX { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathY;
	[Field ("MDMKeyPathY", "__Internal")]
	NSString MDMKeyPathY { get; }

	// extern MDMAnimatableKeyPath MDMKeyPathZ;
	[Field ("MDMKeyPathZ", "__Internal")]
	NSString MDMKeyPathZ { get; }
}

// @protocol MDMRepetitionTraits <NSObject, NSCopying>

// @interface MDMAnimationTraits : NSObject <NSCopying>

// @interface SystemTraits (MDMAnimationTraits)

// @interface Legacy (MDMAnimationTraits)

// @protocol MDMCoreAnimationTraceable

// @interface MDMRepetition : NSObject <NSCopying, MDMRepetitionTraits>

// @interface MDMRepetitionOverTime : NSObject <NSCopying, MDMRepetitionTraits>

// @interface MDMSpringTimingCurve : NSObject <NSCopying, MDMTimingCurve>

// @interface MDMSpringTimingCurveGenerator : NSObject <NSCopying, MDMTimingCurve>

// @interface MDMMotionAnimator : NSObject <MDMCoreAnimationTraceable>

// @interface UIKitEquivalency (MDMMotionAnimator)

// @interface Legacy (MDMMotionAnimator)

// @interface ImplicitLayerAnimations (MDMMotionAnimator)

// @protocol MDMTransition <NSObject>

// @protocol MDMTransitionWithCustomDuration <MDMTransition>

// @protocol MDMTransitionWithFallback <MDMTransition>

// @protocol MDMTransitionWithFeasibility <MDMTransition>

// @protocol MDMTransitionWithPresentation <MDMTransition>

// @protocol MDMTransitionContext

// @protocol MDMTransitionController

// @interface MDMTransitionNavigationControllerDelegate : NSObject

// typedef CGRect (^MDMTransitionFrameCalculation)(UIPresentationController * _Nonnull);

// @interface MDMTransitionPresentationController : UIPresentationController

// @protocol MDMTransitionPresentationAnimationControlling <NSObject>

// @interface MDMTransitionViewSnapshotter : NSObject

// @interface MDCTimingFunction (UIView)

// @interface AppExtensions (UIApplication)

// @interface MDCCardReordering (UICollectionViewController) <UIGestureRecognizerDelegate>

// @interface MaterialSimpleEquality (UIFont)

// @interface MaterialTypography (UIFont)

// @interface MaterialTypography (UIFontDescriptor)

// @interface ic_arrow_back (MDCIcons)

// @interface ic_check (MDCIcons)

// @interface ic_check_circle (MDCIcons)

// @interface ic_chevron_right (MDCIcons)

// @interface ic_color_lens (MDCIcons)

// @interface ic_help_outline (MDCIcons)

// @interface ic_info (MDCIcons)

// @interface ic_more_horiz (MDCIcons)

// @interface ic_radio_button_unchecked (MDCIcons)

// @interface ic_reorder (MDCIcons)

// @interface ic_settings (MDCIcons)

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double MaterialComponentsVersionNumber;
	[Field ("MaterialComponentsVersionNumber", "__Internal")]
	double MaterialComponentsVersionNumber { get; }

	// extern const unsigned char [] MaterialComponentsVersionString;
	[Field ("MaterialComponentsVersionString", "__Internal")]
	byte[] MaterialComponentsVersionString { get; }

	// extern double MotionAnimatorVersionNumber;
	[Field ("MotionAnimatorVersionNumber", "__Internal")]
	double MotionAnimatorVersionNumber { get; }

	// extern const unsigned char [] MotionAnimatorVersionString;
	[Field ("MotionAnimatorVersionString", "__Internal")]
	byte[] MotionAnimatorVersionString { get; }

	// extern double MotionInterchangeVersionNumber;
	[Field ("MotionInterchangeVersionNumber", "__Internal")]
	double MotionInterchangeVersionNumber { get; }

	// extern const unsigned char [] MotionInterchangeVersionString;
	[Field ("MotionInterchangeVersionString", "__Internal")]
	byte[] MotionInterchangeVersionString { get; }
}

// @interface MDMTransitionController (UIViewController)

[Static]
[Verify (ConstantsInterfaceAssociation)]
partial interface Constants
{
	// extern double MotionTransitioningVersionNumber;
	[Field ("MotionTransitioningVersionNumber", "__Internal")]
	double MotionTransitioningVersionNumber { get; }

	// extern const unsigned char [] MotionTransitioningVersionString;
	[Field ("MotionTransitioningVersionString", "__Internal")]
	byte[] MotionTransitioningVersionString { get; }
}