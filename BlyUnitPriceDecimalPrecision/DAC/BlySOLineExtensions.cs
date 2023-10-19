using PX.Data;
using PX.Objects.CM;
using PX.Objects.SO;
using System;

namespace BlyUnitPriceDecimalPrecision
{
    [PXNonInstantiatedExtension]
  public class SO_SOLine_ExistingColumn : PXCacheExtension<PX.Objects.SO.SOLine>
  {
      #region CuryUnitPrice  
      [PXDBCurrency(2, typeof(SOLine.curyInfoID), typeof(SOLine.unitPrice))]
[PXUIField(DisplayName = "Unit Price", Visibility = PXUIVisibility.SelectorVisible)]
[PXDefault(TypeCode.Decimal, "0.0")]
      public Decimal? CuryUnitPrice { get; set; }
      #endregion
  }
}