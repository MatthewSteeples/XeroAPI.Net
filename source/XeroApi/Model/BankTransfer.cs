using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XeroApi.Model
{
    public class BankTransfer : EndpointModelBase
    {
        [ItemId]
        public Guid BankTransferID { get; set; }

        [ItemUpdatedDate]
        public DateTime? UpdatedDateUTC { get; set; }

        public DateTime? Date { get; set; }

        public Account FromAccount { get; set; }

        public Account ToAccount { get; set; }

        public decimal Amount { get; set; }

        [ReadOnly]
        public decimal? CurrencyRate { get; set; }

        [ReadOnly]
        public Guid? FromBankTransactionID { get; set; }

        [ReadOnly]
        public Guid? ToBankTransactionID { get; set; }
    }
}
