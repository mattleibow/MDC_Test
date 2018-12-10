using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewController))]
interface MDCCollectionViewController : IMDCCollectionViewEditingDelegate, IMDCCollectionViewStylingDelegate, IUICollectionViewDelegateFlowLayout
{
    // @property (readonly, nonatomic, strong) id<MDCCollectionViewStyling> _Nonnull styler;
    [Export ("styler", ArgumentSemantic.Strong)]
    MDCCollectionViewStyling Styler { get; }

    // @property (readonly, nonatomic, strong) id<MDCCollectionViewEditing> _Nonnull editor;
    [Export ("editor", ArgumentSemantic.Strong)]
    MDCCollectionViewEditing Editor { get; }

    // -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:shouldHighlightItemAtIndexPath:")]
    [RequiresSuper]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didHighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:didHighlightItemAtIndexPath:")]
    [RequiresSuper]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didUnhighlightItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:didUnhighlightItemAtIndexPath:")]
    [RequiresSuper]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:shouldSelectItemAtIndexPath:")]
    [RequiresSuper]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView shouldDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:shouldDeselectItemAtIndexPath:")]
    [RequiresSuper]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didSelectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:didSelectItemAtIndexPath:")]
    [RequiresSuper]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeselectItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath __attribute__((objc_requires_super));
    [Export ("collectionView:didDeselectItemAtIndexPath:")]
    [RequiresSuper]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // -(void)collectionViewWillBeginEditing:(UICollectionView * _Nonnull)collectionView __attribute__((objc_requires_super));
    [Export ("collectionViewWillBeginEditing:")]
    [RequiresSuper]
    void CollectionViewWillBeginEditing (UICollectionView collectionView);

    // -(void)collectionViewWillEndEditing:(UICollectionView * _Nonnull)collectionView __attribute__((objc_requires_super));
    [Export ("collectionViewWillEndEditing:")]
    [RequiresSuper]
    void CollectionViewWillEndEditing (UICollectionView collectionView);

    // -(CGFloat)cellWidthAtSectionIndex:(NSInteger)section;
    [Export ("cellWidthAtSectionIndex:")]
    nfloat CellWidthAtSectionIndex (nint section);
}