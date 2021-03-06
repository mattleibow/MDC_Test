﻿using System;
using Foundation;
using ObjCRuntime;

[BaseType (typeof(MDCCornerTreatment))]
interface MDCCutCornerTreatment
{
    // @property (assign, nonatomic) CGFloat cut;
    [Export ("cut")]
    nfloat Cut { get; set; }

    // -(instancetype _Nonnull)initWithCut:(CGFloat)cut __attribute__((objc_designated_initializer));
    [Export ("initWithCut:")]
    [DesignatedInitializer]
    IntPtr Constructor (nfloat cut);
}