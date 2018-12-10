using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCCollectionViewStyling
{
    // @required @property (readonly, nonatomic, weak) UICollectionView * _Nullable collectionView;
    [Abstract]
    [NullAllowed, Export ("collectionView", ArgumentSemantic.Weak)]
    UICollectionView CollectionView { get; }

    [Wrap ("WeakDelegate"), Abstract]
    [NullAllowed]
    MDCCollectionViewStylingDelegate Delegate { get; set; }

    // @required @property (nonatomic, weak) id<MDCCollectionViewStylingDelegate> _Nullable delegate;
    [Abstract]
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @required @property (assign, nonatomic) BOOL shouldInvalidateLayout;
    [Abstract]
    [Export ("shouldInvalidateLayout")]
    bool ShouldInvalidateLayout { get; set; }

    // @required @property (nonatomic, strong) UIColor * _Nonnull cellBackgroundColor;
    [Abstract]
    [Export ("cellBackgroundColor", ArgumentSemantic.Strong)]
    UIColor CellBackgroundColor { get; set; }

    // @required @property (assign, nonatomic) MDCCollectionViewCellLayoutType cellLayoutType;
    [Abstract]
    [Export ("cellLayoutType", ArgumentSemantic.Assign)]
    MDCCollectionViewCellLayoutType CellLayoutType { get; set; }

    // @required @property (assign, nonatomic) NSInteger gridColumnCount;
    [Abstract]
    [Export ("gridColumnCount")]
    nint GridColumnCount { get; set; }

    // @required @property (assign, nonatomic) CGFloat gridPadding;
    [Abstract]
    [Export ("gridPadding")]
    nfloat GridPadding { get; set; }

    // @required @property (assign, nonatomic) MDCCollectionViewCellStyle cellStyle;
    [Abstract]
    [Export ("cellStyle", ArgumentSemantic.Assign)]
    MDCCollectionViewCellStyle CellStyle { get; set; }

    // @required @property (nonatomic) CGFloat cardBorderRadius;
    [Abstract]
    [Export ("cardBorderRadius")]
    nfloat CardBorderRadius { get; set; }

    // @required -(void)setCellStyle:(MDCCollectionViewCellStyle)cellStyle animated:(BOOL)animated;
    [Abstract]
    [Export ("setCellStyle:animated:")]
    void SetCellStyle (MDCCollectionViewCellStyle cellStyle, bool animated);

    // @required -(MDCCollectionViewCellStyle)cellStyleAtSectionIndex:(NSInteger)section;
    [Abstract]
    [Export ("cellStyleAtSectionIndex:")]
    MDCCollectionViewCellStyle CellStyleAtSectionIndex (nint section);

    // @required -(UIEdgeInsets)backgroundImageViewOutsetsForCellWithAttribute:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
    [Abstract]
    [Export ("backgroundImageViewOutsetsForCellWithAttribute:")]
    UIEdgeInsets BackgroundImageViewOutsetsForCellWithAttribute (MDCCollectionViewLayoutAttributes attr);

    // @required -(UIImage * _Nullable)backgroundImageForCellLayoutAttributes:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
    [Abstract]
    [Export ("backgroundImageForCellLayoutAttributes:")]
    [return: NullAllowed]
    UIImage BackgroundImageForCellLayoutAttributes (MDCCollectionViewLayoutAttributes attr);

    // @required @property (nonatomic, strong) UIColor * _Nullable separatorColor;
    [Abstract]
    [NullAllowed, Export ("separatorColor", ArgumentSemantic.Strong)]
    UIColor SeparatorColor { get; set; }

    // @required @property (nonatomic) UIEdgeInsets separatorInset;
    [Abstract]
    [Export ("separatorInset", ArgumentSemantic.Assign)]
    UIEdgeInsets SeparatorInset { get; set; }

    // @required @property (nonatomic) CGFloat separatorLineHeight;
    [Abstract]
    [Export ("separatorLineHeight")]
    nfloat SeparatorLineHeight { get; set; }

    // @required @property (nonatomic) BOOL shouldHideSeparators;
    [Abstract]
    [Export ("shouldHideSeparators")]
    bool ShouldHideSeparators { get; set; }

    // @required -(BOOL)shouldHideSeparatorForCellLayoutAttributes:(MDCCollectionViewLayoutAttributes * _Nonnull)attr;
    [Abstract]
    [Export ("shouldHideSeparatorForCellLayoutAttributes:")]
    bool ShouldHideSeparatorForCellLayoutAttributes (MDCCollectionViewLayoutAttributes attr);

    // @required @property (assign, nonatomic) BOOL allowsItemInlay;
    [Abstract]
    [Export ("allowsItemInlay")]
    bool AllowsItemInlay { get; set; }

    // @required @property (assign, nonatomic) BOOL allowsMultipleItemInlays;
    [Abstract]
    [Export ("allowsMultipleItemInlays")]
    bool AllowsMultipleItemInlays { get; set; }

    // @required -(NSArray<NSIndexPath *> * _Nullable)indexPathsForInlaidItems;
    [Abstract]
    [NullAllowed, Export ("indexPathsForInlaidItems")]
    [Verify (MethodToProperty)]
    NSIndexPath[] IndexPathsForInlaidItems { get; }

    // @required -(BOOL)isItemInlaidAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Abstract]
    [Export ("isItemInlaidAtIndexPath:")]
    bool IsItemInlaidAtIndexPath (NSIndexPath indexPath);

    // @required -(void)applyInlayToItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
    [Abstract]
    [Export ("applyInlayToItemAtIndexPath:animated:")]
    void ApplyInlayToItemAtIndexPath (NSIndexPath indexPath, bool animated);

    // @required -(void)removeInlayFromItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath animated:(BOOL)animated;
    [Abstract]
    [Export ("removeInlayFromItemAtIndexPath:animated:")]
    void RemoveInlayFromItemAtIndexPath (NSIndexPath indexPath, bool animated);

    // @required -(void)applyInlayToAllItemsAnimated:(BOOL)animated;
    [Abstract]
    [Export ("applyInlayToAllItemsAnimated:")]
    void ApplyInlayToAllItemsAnimated (bool animated);

    // @required -(void)removeInlayFromAllItemsAnimated:(BOOL)animated;
    [Abstract]
    [Export ("removeInlayFromAllItemsAnimated:")]
    void RemoveInlayFromAllItemsAnimated (bool animated);

    // @required -(void)resetIndexPathsForInlaidItems;
    [Abstract]
    [Export ("resetIndexPathsForInlaidItems")]
    void ResetIndexPathsForInlaidItems ();

    // @required @property (assign, nonatomic) BOOL shouldAnimateCellsOnAppearance;
    [Abstract]
    [Export ("shouldAnimateCellsOnAppearance")]
    bool ShouldAnimateCellsOnAppearance { get; set; }

    // @required @property (readonly, assign, nonatomic) BOOL willAnimateCellsOnAppearance;
    [Abstract]
    [Export ("willAnimateCellsOnAppearance")]
    bool WillAnimateCellsOnAppearance { get; }

    // @required @property (readonly, assign, nonatomic) CGFloat animateCellsOnAppearancePadding;
    [Abstract]
    [Export ("animateCellsOnAppearancePadding")]
    nfloat AnimateCellsOnAppearancePadding { get; }

    // @required @property (readonly, assign, nonatomic) NSTimeInterval animateCellsOnAppearanceDuration;
    [Abstract]
    [Export ("animateCellsOnAppearanceDuration")]
    double AnimateCellsOnAppearanceDuration { get; }

    // @required -(void)beginCellAppearanceAnimation;
    [Abstract]
    [Export ("beginCellAppearanceAnimation")]
    void BeginCellAppearanceAnimation ();
}