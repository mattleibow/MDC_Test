using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDCFlexibleHeaderViewDelegate
{
    // @required -(void)flexibleHeaderViewNeedsStatusBarAppearanceUpdate:(MDCFlexibleHeaderView * _Nonnull)headerView;
    [Abstract]
    [Export ("flexibleHeaderViewNeedsStatusBarAppearanceUpdate:")]
    void FlexibleHeaderViewNeedsStatusBarAppearanceUpdate (MDCFlexibleHeaderView headerView);

    // @required -(void)flexibleHeaderViewFrameDidChange:(MDCFlexibleHeaderView * _Nonnull)headerView;
    [Abstract]
    [Export ("flexibleHeaderViewFrameDidChange:")]
    void FlexibleHeaderViewFrameDidChange (MDCFlexibleHeaderView headerView);
}