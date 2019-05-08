using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.SqlClient;
namespace Sample.Entities
{
    public partial class UspInsertsalesorderOndisk
    {
        private readonly SampleDbContext context;
        public UspInsertsalesorderOndisk()
        {
            context = new SampleDbContext();
        }
        public UspInsertsalesorderOndisk(SampleDbContext context)
        {
            this.context = context;
        }

        ///<summary>execute command Sales.usp_InsertSalesOrder_ondisk</summary>
        public int Execute(
            ref int? salesOrderId, 
            DateTime? dueDate, 
            int? customerId, 
            int? billToAddressId, 
            int? shipToAddressId, 
            int? shipMethodId, 
            object salesOrderDetails, 
            byte? status, 
            bool? onlineOrderFlag, 
            string purchaseOrderNumber, 
            string accountNumber, 
            int? salesPersonId, 
            int? territoryId, 
            int? creditCardId, 
            string creditCardApprovalCode, 
            int? currencyRateId, 
            string comment
        )
        {
            var returnValue = new SqlParameter() {ParameterName = "@return_value",  Direction = System.Data.ParameterDirection.ReturnValue};
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId){ Direction = System.Data.ParameterDirection.InputOutput };
            var p1 = new SqlParameter("@DueDate",  dueDate);
            var p2 = new SqlParameter("@CustomerID",  customerId);
            var p3 = new SqlParameter("@BillToAddressID",  billToAddressId);
            var p4 = new SqlParameter("@ShipToAddressID",  shipToAddressId);
            var p5 = new SqlParameter("@ShipMethodID",  shipMethodId);
            var p6 = new SqlParameter("@SalesOrderDetails",  salesOrderDetails);
            var p7 = new SqlParameter("@Status",  status);
            var p8 = new SqlParameter("@OnlineOrderFlag",  onlineOrderFlag);
            var p9 = new SqlParameter("@PurchaseOrderNumber",  purchaseOrderNumber);
            var p10 = new SqlParameter("@AccountNumber",  accountNumber);
            var p11 = new SqlParameter("@SalesPersonID",  salesPersonId);
            var p12 = new SqlParameter("@TerritoryID",  territoryId);
            var p13 = new SqlParameter("@CreditCardID",  creditCardId);
            var p14 = new SqlParameter("@CreditCardApprovalCode",  creditCardApprovalCode);
            var p15 = new SqlParameter("@CurrencyRateID",  currencyRateId);
            var p16 = new SqlParameter("@Comment",  comment);

            var affected = context.Database.ExecuteSqlCommand(@"EXEC @return_value = [Sales].[usp_InsertSalesOrder_ondisk]
@SalesOrderID = @SalesOrderID,
@DueDate = @DueDate,
@CustomerID = @CustomerID,
@BillToAddressID = @BillToAddressID,
@ShipToAddressID = @ShipToAddressID,
@ShipMethodID = @ShipMethodID,
@SalesOrderDetails = @SalesOrderDetails,
@Status = @Status,
@OnlineOrderFlag = @OnlineOrderFlag,
@PurchaseOrderNumber = @PurchaseOrderNumber,
@AccountNumber = @AccountNumber,
@SalesPersonID = @SalesPersonID,
@TerritoryID = @TerritoryID,
@CreditCardID = @CreditCardID,
@CreditCardApprovalCode = @CreditCardApprovalCode,
@CurrencyRateID = @CurrencyRateID,
@Comment = @Comment",
                returnValue, 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6, 
                p7, 
                p8, 
                p9, 
                p10, 
                p11, 
                p12, 
                p13, 
                p14, 
                p15, 
                p16);

            salesOrderId = (int?)p0.Value;
            return (int)returnValue.Value;
        }
        ///<summary>execute query Sales.usp_InsertSalesOrder_ondisk</summary>
        public IEnumerable<T> Query<T>(
            ref int? salesOrderId, 
            DateTime? dueDate, 
            int? customerId, 
            int? billToAddressId, 
            int? shipToAddressId, 
            int? shipMethodId, 
            object salesOrderDetails, 
            byte? status, 
            bool? onlineOrderFlag, 
            string purchaseOrderNumber, 
            string accountNumber, 
            int? salesPersonId, 
            int? territoryId, 
            int? creditCardId, 
            string creditCardApprovalCode, 
            int? currencyRateId, 
            string comment
        )
        {
            var p0 = new SqlParameter("@SalesOrderID",  salesOrderId){ Direction = System.Data.ParameterDirection.InputOutput };
            var p1 = new SqlParameter("@DueDate",  dueDate);
            var p2 = new SqlParameter("@CustomerID",  customerId);
            var p3 = new SqlParameter("@BillToAddressID",  billToAddressId);
            var p4 = new SqlParameter("@ShipToAddressID",  shipToAddressId);
            var p5 = new SqlParameter("@ShipMethodID",  shipMethodId);
            var p6 = new SqlParameter("@SalesOrderDetails",  salesOrderDetails);
            var p7 = new SqlParameter("@Status",  status);
            var p8 = new SqlParameter("@OnlineOrderFlag",  onlineOrderFlag);
            var p9 = new SqlParameter("@PurchaseOrderNumber",  purchaseOrderNumber);
            var p10 = new SqlParameter("@AccountNumber",  accountNumber);
            var p11 = new SqlParameter("@SalesPersonID",  salesPersonId);
            var p12 = new SqlParameter("@TerritoryID",  territoryId);
            var p13 = new SqlParameter("@CreditCardID",  creditCardId);
            var p14 = new SqlParameter("@CreditCardApprovalCode",  creditCardApprovalCode);
            var p15 = new SqlParameter("@CurrencyRateID",  currencyRateId);
            var p16 = new SqlParameter("@Comment",  comment);

            var result = context.Database.SqlQuery<T>(@"EXEC [Sales].[usp_InsertSalesOrder_ondisk]
@SalesOrderID = @SalesOrderID,
@DueDate = @DueDate,
@CustomerID = @CustomerID,
@BillToAddressID = @BillToAddressID,
@ShipToAddressID = @ShipToAddressID,
@ShipMethodID = @ShipMethodID,
@SalesOrderDetails = @SalesOrderDetails,
@Status = @Status,
@OnlineOrderFlag = @OnlineOrderFlag,
@PurchaseOrderNumber = @PurchaseOrderNumber,
@AccountNumber = @AccountNumber,
@SalesPersonID = @SalesPersonID,
@TerritoryID = @TerritoryID,
@CreditCardID = @CreditCardID,
@CreditCardApprovalCode = @CreditCardApprovalCode,
@CurrencyRateID = @CurrencyRateID,
@Comment = @Comment", 
                p0, 
                p1, 
                p2, 
                p3, 
                p4, 
                p5, 
                p6, 
                p7, 
                p8, 
                p9, 
                p10, 
                p11, 
                p12, 
                p13, 
                p14, 
                p15, 
                p16);

            salesOrderId = (int?)p0.Value;
            return result;
        }

    }
}
