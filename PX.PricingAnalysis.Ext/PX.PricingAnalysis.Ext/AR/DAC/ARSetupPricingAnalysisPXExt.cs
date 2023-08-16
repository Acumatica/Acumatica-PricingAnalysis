﻿using PX.Data;
using PX.Objects.AR;
using System;

namespace PX.PricingAnalysis.Ext
{
    public sealed class ARSetupPricingAnalysisPXExt : PXCacheExtension<ARSetup>
    {
        #region UsrDefAdjustmentType
        public abstract class usrDefAdjustmentType : PX.Data.BQL.BqlString.Field<usrDefAdjustmentType> { }

        [PXDBString(1, IsFixed = true)]
        [PXUIField(DisplayName = "Default Adjustment Type")]
        [PXDefault(typeof(BreakupBy.markup), PersistingCheck =PXPersistingCheck.NullOrBlank)]
        [AdjustmentType.List]
        public String UsrDefAdjustmentType { get; set; }
        #endregion

        #region UsrDefPricingType
        public abstract class usrDefPricingType : PX.Data.BQL.BqlString.Field<usrDefPricingType> { }

        [PXDBString(2, IsFixed = true)]
        [PXUIField(DisplayName = "Default Pricing By")]
        [BreakupBy.List]
        [PXDefault(BreakupBy.Markup, PersistingCheck = PXPersistingCheck.Nothing)]
        public string UsrDefPricingType { get; set; }
        #endregion
    }
}