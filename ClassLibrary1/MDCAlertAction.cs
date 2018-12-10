using Foundation;

[BaseType (typeof(NSObject))]
[DisableDefaultCtor]
interface MDCAlertAction : INSCopying
{
    // +(instancetype _Nonnull)actionWithTitle:(NSString * _Nonnull)title handler:(MDCActionHandler _Nullable)handler;
    [Static]
    [Export ("actionWithTitle:handler:")]
    MDCAlertAction ActionWithTitle (string title, [NullAllowed] MDCActionHandler handler);

    // @property (readonly, nonatomic) NSString * _Nullable title;
    [NullAllowed, Export ("title")]
    string Title { get; }
}