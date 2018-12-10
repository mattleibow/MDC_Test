using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCCollectionViewEditing
{
    // @required @property (readonly, nonatomic, weak) UICollectionView * _Nullable collectionView;
    [Abstract]
    [NullAllowed, Export ("collectionView", ArgumentSemantic.Weak)]
    UICollectionView CollectionView { get; }

    [Wrap ("WeakDelegate"), Abstract]
    [NullAllowed]
    MDCCollectionViewEditingDelegate Delegate { get; set; }

    // @required @property (nonatomic, weak) id<MDCCollectionViewEditingDelegate> _Nullable delegate;
    [Abstract]
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @required @property (readonly, nonatomic, strong) NSIndexPath * _Nullable reorderingCellIndexPath;
    [Abstract]
    [NullAllowed, Export ("reorderingCellIndexPath", ArgumentSemantic.Strong)]
    NSIndexPath ReorderingCellIndexPath { get; }

    // @required @property (readonly, nonatomic, strong) NSIndexPath * _Nullable dismissingCellIndexPath;
    [Abstract]
    [NullAllowed, Export ("dismissingCellIndexPath", ArgumentSemantic.Strong)]
    NSIndexPath DismissingCellIndexPath { get; }

    // @required @property (readonly, assign, nonatomic) NSInteger dismissingSection;
    [Abstract]
    [Export ("dismissingSection")]
    nint DismissingSection { get; }

    // @required @property (getter = isEditing, nonatomic) BOOL editing;
    [Abstract]
    [Export ("editing")]
    bool Editing { [Bind ("isEditing")] get; set; }

    // @required -(void)setEditing:(BOOL)editing animated:(BOOL)animated;
    [Abstract]
    [Export ("setEditing:animated:")]
    void Animated (bool editing, bool animated);
}