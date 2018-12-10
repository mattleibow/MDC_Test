using Foundation;

[Protocol, Model]
[BaseType (typeof(NSObject))]
interface MDMRepetitionTraits : INSCopying
{
    // @required @property (assign, nonatomic) BOOL autoreverses;
    [Abstract]
    [Export ("autoreverses")]
    bool Autoreverses { get; set; }
}