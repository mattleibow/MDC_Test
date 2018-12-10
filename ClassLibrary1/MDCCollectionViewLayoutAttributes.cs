using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewLayoutAttributes))]
interface MDCCollectionViewLayoutAttributes : INSCopying
{
    // @property (getter = isEditing, nonatomic) BOOL editing;
    [Export ("editing")]
    bool Editing { [Bind ("isEditing")] get; set; }

    // @property (assign, nonatomic) BOOL shouldShowReorderStateMask;
    [Export ("shouldShowReorderStateMask")]
    bool ShouldShowReorderStateMask { get; set; }

    // @property (assign, nonatomic) BOOL shouldShowSelectorStateMask;
    [Export ("shouldShowSelectorStateMask")]
    bool ShouldShowSelectorStateMask { get; set; }

    // @property (assign, nonatomic) BOOL shouldShowGridBackground;
    [Export ("shouldShowGridBackground")]
    bool ShouldShowGridBackground { get; set; }

    // @property (nonatomic, strong) UIImage * _Nullable backgroundImage;
    [NullAllowed, Export ("backgroundImage", ArgumentSemantic.Strong)]
    UIImage BackgroundImage { get; set; }

    // @property (nonatomic) UIEdgeInsets backgroundImageViewInsets;
    [Export ("backgroundImageViewInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets BackgroundImageViewInsets { get; set; }

    // @property (assign, nonatomic) BOOL isGridLayout;
    [Export ("isGridLayout")]
    bool IsGridLayout { get; set; }

    // @property (assign, nonatomic) MDCCollectionViewOrdinalPosition sectionOrdinalPosition;
    [Export ("sectionOrdinalPosition", ArgumentSemantic.Assign)]
    MDCCollectionViewOrdinalPosition SectionOrdinalPosition { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable separatorColor;
    [NullAllowed, Export ("separatorColor", ArgumentSemantic.Strong)]
    UIColor SeparatorColor { get; set; }

    // @property (nonatomic) UIEdgeInsets separatorInset;
    [Export ("separatorInset", ArgumentSemantic.Assign)]
    UIEdgeInsets SeparatorInset { get; set; }

    // @property (nonatomic) CGFloat separatorLineHeight;
    [Export ("separatorLineHeight")]
    nfloat SeparatorLineHeight { get; set; }

    // @property (nonatomic) BOOL shouldHideSeparators;
    [Export ("shouldHideSeparators")]
    bool ShouldHideSeparators { get; set; }

    // @property (assign, nonatomic) BOOL willAnimateCellsOnAppearance;
    [Export ("willAnimateCellsOnAppearance")]
    bool WillAnimateCellsOnAppearance { get; set; }

    // @property (assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDuration;
    [Export ("animateCellsOnAppearanceDuration")]
    double AnimateCellsOnAppearanceDuration { get; set; }

    // @property (assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDelay;
    [Export ("animateCellsOnAppearanceDelay")]
    double AnimateCellsOnAppearanceDelay { get; set; }
}