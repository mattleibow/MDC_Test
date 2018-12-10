using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

[BaseType (typeof(UIControl))]
interface MDCPageControl : IUIScrollViewDelegate
{
    // @property (nonatomic) NSInteger numberOfPages;
    [Export ("numberOfPages")]
    nint NumberOfPages { get; set; }

    // @property (nonatomic) NSInteger currentPage;
    [Export ("currentPage")]
    nint CurrentPage { get; set; }

    // -(void)setCurrentPage:(NSInteger)currentPage animated:(BOOL)animated;
    [Export ("setCurrentPage:animated:")]
    void SetCurrentPage (nint currentPage, bool animated);

    // @property (nonatomic) BOOL hidesForSinglePage;
    [Export ("hidesForSinglePage")]
    bool HidesForSinglePage { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable pageIndicatorTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("pageIndicatorTintColor", ArgumentSemantic.Strong)]
    UIColor PageIndicatorTintColor { get; set; }

    // @property (nonatomic, strong) UIColor * _Nullable currentPageIndicatorTintColor __attribute__((annotate("ui_appearance_selector")));
    [NullAllowed, Export ("currentPageIndicatorTintColor", ArgumentSemantic.Strong)]
    UIColor CurrentPageIndicatorTintColor { get; set; }

    // @property (nonatomic) BOOL defersCurrentPageDisplay;
    [Export ("defersCurrentPageDisplay")]
    bool DefersCurrentPageDisplay { get; set; }

    // @property (nonatomic) BOOL respectsUserInterfaceLayoutDirection;
    [Export ("respectsUserInterfaceLayoutDirection")]
    bool RespectsUserInterfaceLayoutDirection { get; set; }

    // -(void)updateCurrentPageDisplay;
    [Export ("updateCurrentPageDisplay")]
    void UpdateCurrentPageDisplay ();

    // +(CGSize)sizeForNumberOfPages:(NSInteger)pageCount;
    [Static]
    [Export ("sizeForNumberOfPages:")]
    CGSize SizeForNumberOfPages (nint pageCount);

    // -(void)scrollViewDidScroll:(UIScrollView * _Nonnull)scrollView;
    [Export ("scrollViewDidScroll:")]
    void ScrollViewDidScroll (UIScrollView scrollView);

    // -(void)scrollViewDidEndDecelerating:(UIScrollView * _Nonnull)scrollView;
    [Export ("scrollViewDidEndDecelerating:")]
    void ScrollViewDidEndDecelerating (UIScrollView scrollView);

    // -(void)scrollViewDidEndScrollingAnimation:(UIScrollView * _Nonnull)scrollView;
    [Export ("scrollViewDidEndScrollingAnimation:")]
    void ScrollViewDidEndScrollingAnimation (UIScrollView scrollView);
}