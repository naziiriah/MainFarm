using MainFarm.Enums;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace MainFarm.Model;

public class Transaction : MainFarmBase
{
    public string? Reference { get; set; }
    public decimal Amount { get; set; }
    public decimal ServiceFee { get; set; }
    public Guid? SessionGuid { get; set; }
    public Guid? WaiterGuid { get; set; }
    public DateTime TransactionDate { get; set; }
    public ePaymentMethods PaymentMethod { get; set; }
}
