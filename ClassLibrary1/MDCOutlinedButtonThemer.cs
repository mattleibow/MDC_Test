﻿using Foundation;

[BaseType (typeof(NSObject))]
interface MDCOutlinedButtonThemer
{
    // +(void)applyScheme:(id<MDCButtonScheming> _Nonnull)scheme toButton:(MDCButton * _Nonnull)button;
    [Static]
    [Export ("applyScheme:toButton:")]
    void ApplyScheme (MDCButtonScheming scheme, MDCButton button);
}