using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UICollectionViewCell))]
interface MDCCollectionViewCell
{
    // @property (nonatomic) MDCCollectionViewCellAccessoryType accessoryType;
    [Export ("accessoryType", ArgumentSemantic.Assign)]
    MDCCollectionViewCellAccessoryType AccessoryType { get; set; }

    // @property (nonatomic, strong) UIView * _Nullable accessoryView;
    [NullAllowed, Export ("accessoryView", ArgumentSemantic.Strong)]
    UIView AccessoryView { get; set; }

    // @property (nonatomic) UIEdgeInsets accessoryInset;
    [Export ("accessoryInset", ArgumentSemantic.Assign)]
    UIEdgeInsets AccessoryInset { get; set; }

    // @property (nonatomic) BOOL shouldHideSeparator;
    [Export ("shouldHideSeparator")]
    bool ShouldHideSeparator { get; set; }

    // @property (nonatomic) UIEdgeInsets separatorInset;
    [Export ("separatorInset", ArgumentSemantic.Assign)]
    UIEdgeInsets SeparatorInset { get; set; }

    // @property (nonatomic) BOOL allowsCellInteractionsWhileEditing;
    [Export ("allowsCellInteractionsWhileEditing")]
    bool AllowsCellInteractionsWhileEditing { get; set; }

    // @property (getter = isEditing, nonatomic) BOOL editing;
    [Export ("editing")]
    bool Editing { [Bind ("isEditing")] get; set; }

    // @property (nonatomic, strong) UIColor * _Null_unspecified editingSelectorColor __attribute__((annotate("ui_appearance_selector")));
    [Export ("editingSelectorColor", ArgumentSemantic.Strong)]
    UIColor EditingSelectorColor { get; set; }

    // -(void)setEditing:(BOOL)editing animated:(BOOL)animated;
    [Export ("setEditing:animated:")]
    void SetEditing (bool editing, bool animated);

    // @property (nonatomic, strong) MDCInkView * _Nullable inkView;
    [NullAllowed, Export ("inkView", ArgumentSemantic.Strong)]
    MDCInkView InkView { get; set; }
}