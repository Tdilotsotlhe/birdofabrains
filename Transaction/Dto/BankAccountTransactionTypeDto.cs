using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    public class BankAccountTransactionTypeDto : CachableDto
    {
        public BankAccountTransactionTypeDto()
        {
        }
        [DataMember]
        public int BankAccountTransactionTypeID { get; set; }
        //[DataMember]
        //public BankAccountTransactionsDto BankAccountTransactions { get; set; }
        [DataMember]
        public Nullable<int> GLAccountID { get; set; }
        //[DataMember]
        //public BankAccountTransactionCodesDto BankAccountTransactionCodes { get; set; }
        [DataMember]
        public string DrCrInd { get; set; }
    }
}