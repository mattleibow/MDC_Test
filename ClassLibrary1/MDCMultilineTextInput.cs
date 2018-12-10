using System;
using Foundation;

[Protocol, Model]
interface MDCMultilineTextInput : IMDCTextInput
{
    // @required @property (assign, nonatomic) BOOL expandsOnOverflow;
    [Abstract]
    [Export ("expandsOnOverflow")]
    bool ExpandsOnOverflow { get; set; }

    // @required @property (assign, nonatomic) NSUInteger minimumLines __attribute__((annotate("ui_appearance_selector")));
    [Abstract]
    [Export ("minimumLines")]
    nuint MinimumLines { get; set; }
}