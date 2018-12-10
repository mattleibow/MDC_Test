using Foundation;

[BaseType (typeof(MDCButton))]
interface MDCFlatButton
{
    // @property (nonatomic) BOOL hasOpaqueBackground;
    [Export ("hasOpaqueBackground")]
    bool HasOpaqueBackground { get; set; }
}