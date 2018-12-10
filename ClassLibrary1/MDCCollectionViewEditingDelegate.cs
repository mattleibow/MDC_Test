using System;
using Foundation;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCCollectionViewEditingDelegate
{
    // @optional -(BOOL)collectionViewAllowsEditing:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewAllowsEditing:")]
    bool CollectionViewAllowsEditing (UICollectionView collectionView);

    // @optional -(void)collectionViewWillBeginEditing:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewWillBeginEditing:")]
    void CollectionViewWillBeginEditing (UICollectionView collectionView);

    // @optional -(void)collectionViewDidBeginEditing:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewDidBeginEditing:")]
    void CollectionViewDidBeginEditing (UICollectionView collectionView);

    // @optional -(void)collectionViewWillEndEditing:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewWillEndEditing:")]
    void CollectionViewWillEndEditing (UICollectionView collectionView);

    // @optional -(void)collectionViewDidEndEditing:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewDidEndEditing:")]
    void CollectionViewDidEndEditing (UICollectionView collectionView);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canEditItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:canEditItemAtIndexPath:")]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSelectItemDuringEditingAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:canSelectItemDuringEditingAtIndexPath:")]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(BOOL)collectionViewAllowsReordering:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewAllowsReordering:")]
    bool CollectionViewAllowsReordering (UICollectionView collectionView);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:canMoveItemAtIndexPath:")]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
    [Export ("collectionView:canMoveItemAtIndexPath:toIndexPath:")]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
    [Export ("collectionView:willMoveItemAtIndexPath:toIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didMoveItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath toIndexPath:(NSIndexPath * _Nonnull)newIndexPath;
    [Export ("collectionView:didMoveItemAtIndexPath:toIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath, NSIndexPath newIndexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginDraggingItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:willBeginDraggingItemAtIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndDraggingItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:didEndDraggingItemAtIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDeleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
    [Export ("collectionView:willDeleteItemsAtIndexPaths:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath[] indexPaths);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeleteItemsAtIndexPaths:(NSArray<NSIndexPath *> * _Nonnull)indexPaths;
    [Export ("collectionView:didDeleteItemsAtIndexPaths:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath[] indexPaths);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willDeleteSections:(NSIndexSet * _Nonnull)sections;
    [Export ("collectionView:willDeleteSections:")]
    void CollectionView (UICollectionView collectionView, NSIndexSet sections);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didDeleteSections:(NSIndexSet * _Nonnull)sections;
    [Export ("collectionView:didDeleteSections:")]
    void CollectionView (UICollectionView collectionView, NSIndexSet sections);

    // @optional -(BOOL)collectionViewAllowsSwipeToDismissItem:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewAllowsSwipeToDismissItem:")]
    bool CollectionViewAllowsSwipeToDismissItem (UICollectionView collectionView);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:canSwipeToDismissItemAtIndexPath:")]
    bool CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:willBeginSwipeToDismissItemAtIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:didEndSwipeToDismissItemAtIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didCancelSwipeToDismissItemAtIndexPath:(NSIndexPath * _Nonnull)indexPath;
    [Export ("collectionView:didCancelSwipeToDismissItemAtIndexPath:")]
    void CollectionView (UICollectionView collectionView, NSIndexPath indexPath);

    // @optional -(BOOL)collectionViewAllowsSwipeToDismissSection:(UICollectionView * _Nonnull)collectionView;
    [Export ("collectionViewAllowsSwipeToDismissSection:")]
    bool CollectionViewAllowsSwipeToDismissSection (UICollectionView collectionView);

    // @optional -(BOOL)collectionView:(UICollectionView * _Nonnull)collectionView canSwipeToDismissSection:(NSInteger)section;
    [Export ("collectionView:canSwipeToDismissSection:")]
    bool CollectionView (UICollectionView collectionView, nint section);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView willBeginSwipeToDismissSection:(NSInteger)section;
    [Export ("collectionView:willBeginSwipeToDismissSection:")]
    void CollectionView (UICollectionView collectionView, nint section);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didEndSwipeToDismissSection:(NSInteger)section;
    [Export ("collectionView:didEndSwipeToDismissSection:")]
    void CollectionView (UICollectionView collectionView, nint section);

    // @optional -(void)collectionView:(UICollectionView * _Nonnull)collectionView didCancelSwipeToDismissSection:(NSInteger)section;
    [Export ("collectionView:didCancelSwipeToDismissSection:")]
    void CollectionView (UICollectionView collectionView, nint section);
}