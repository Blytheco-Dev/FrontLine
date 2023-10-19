using PX.Data;
using PX.Objects.AR;
using System;

namespace BlyUnitPriceDecimalPrecision
{
    [PXNonInstantiatedExtension]
  public class AR_ARTran_ExistingColumn : PXCacheExtension<PX.Objects.AR.ARTran>
  {
      #region CuryUnitPrice  
      [PX.Objects.CM.PXDBCurrency(2,typeof(ARTran.curyInfoID),typeof(ARTran.unitPrice))]
      [PXUIField(DisplayName = "Unit Price", Visibility = PXUIVisibility.SelectorVisible)]
      [PXDefault(TypeCode.Decimal, "0.0")]
      public Decimal? CuryUnitPrice { get; set; }
      #endregion
  }
}