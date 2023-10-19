using PX.Data;
using System;

namespace BlyUnitPriceDecimalPrecision
{
    [PXNonInstantiatedExtension]
  public class AR_ARSalesPrice_ExistingColumn : PXCacheExtension<PX.Objects.AR.ARSalesPrice>
    {
      #region SalesPrice  
      [PXDefault(TypeCode.Decimal, "0.0")]
      [PXDBDecimal(2)]
      [PXUIField(DisplayName = "Price", Visibility = PXUIVisibility.Visible)]
      public Decimal? SalesPrice { get; set; }
      #endregion
  }
}