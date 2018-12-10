using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCFlexibleHeaderViewLayoutDelegate
{
    // @required -(void)flexibleHeaderViewController:(MDCFlexibleHeaderViewController * _Nonnull)flexibleHeaderViewController flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)flexibleHeaderView;
    [Abstract]
    [Export ("flexibleHeaderViewController:flexibleHeaderViewFrameDidChange:")]
    void FlexibleHeaderViewFrameDidChange (MDCFlexibleHeaderViewController flexibleHeaderViewController, MDCFlexibleHeaderView flexibleHeaderView);
}