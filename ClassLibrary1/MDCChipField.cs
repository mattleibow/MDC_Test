using System;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIView))]
interface MDCChipField
{
    // @property (readonly, nonatomic) MDCTextField * _Nonnull textField;
    [Export ("textField")]
    MDCTextField TextField { get; }

    // @property (assign, nonatomic) CGFloat chipHeight;
    [Export ("chipHeight")]
    nfloat ChipHeight { get; set; }

    // @property (assign, nonatomic) BOOL showPlaceholderWithChips;
    [Export ("showPlaceholderWithChips")]
    bool ShowPlaceholderWithChips { get; set; }

    // @property (assign, nonatomic) MDCChipFieldDelimiter delimiter;
    [Export ("delimiter", ArgumentSemantic.Assign)]
    MDCChipFieldDelimiter Delimiter { get; set; }

    // @property (assign, nonatomic) CGFloat minTextFieldWidth;
    [Export ("minTextFieldWidth")]
    nfloat MinTextFieldWidth { get; set; }

    // @property (copy, nonatomic) NSArray<MDCChipView *> * _Nonnull chips;
    [Export ("chips", ArgumentSemantic.Copy)]
    MDCChipView[] Chips { get; set; }

    [Wrap ("WeakDelegate")]
    [NullAllowed]
    MDCChipFieldDelegate Delegate { get; set; }

    // @property (nonatomic, weak) id<MDCChipFieldDelegate> _Nullable delegate;
    [NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
    NSObject WeakDelegate { get; set; }

    // @property (assign, nonatomic) UIEdgeInsets contentEdgeInsets;
    [Export ("contentEdgeInsets", ArgumentSemantic.Assign)]
    UIEdgeInsets ContentEdgeInsets { get; set; }

    // -(void)addChip:(MDCChipView * _Nonnull)chip;
    [Export ("addChip:")]
    void AddChip (MDCChipView chip);

    // -(void)removeChip:(MDCChipView * _Nonnull)chip;
    [Export ("removeChip:")]
    void RemoveChip (MDCChipView chip);

    // -(void)removeSelectedChips;
    [Export ("removeSelectedChips")]
    void RemoveSelectedChips ();

    // -(void)clearTextInput;
    [Export ("clearTextInput")]
    void ClearTextInput ();

    // -(void)selectChip:(MDCChipView * _Nonnull)chip;
    [Export ("selectChip:")]
    void SelectChip (MDCChipView chip);

    // -(void)deselectAllChips;
    [Export ("deselectAllChips")]
    void DeselectAllChips ();

    // -(void)focusTextFieldForAccessibility;
    [Export ("focusTextFieldForAccessibility")]
    void FocusTextFieldForAccessibility ();
}