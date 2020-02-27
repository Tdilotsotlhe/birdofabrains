using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    public class BankAccountDto : CachableDto
    {
        public BankAccountDto()
        {
            StoredProcedureName = StoredProcedureNames.GetAllBankAccounts;
        }

        [DataMember]
        public int BankAccountID { get; set; }
        [DataMember]
        public int BankAccountTypeID { get; set; }
        [DataMember]
        public string AccountHolder { get; set; }
        [DataMember]
        public string AccountDescription { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public int BankBranchCodeID { get; set; }
        [DataMember]
        public int? ACBUserID { get; set; }
        [DataMember]
        public double? DailyDebitAggregateLimit { get; set; }
        [DataMember]
        public double? DebitTransactionLimit { get; set; }
        [DataMember]
        public double? DailyCreditAggregateLimit { get; set; }
        [DataMember]
        public double? CreditTransactionLimit { get; set; }
        [DataMember]
        public double? MonthlyDebitAggregateLimit { get; set; }
        [DataMember]
        public double? MonthlyCreditAggregateLimit { get; set; }
        [DataMember]
        public string GLAccountNumber { get; set; }
        [DataMember]
        public bool? PayInterestInd { get; set; }
        [DataMember]
        public bool? ForexAccount { get; set; }
        [DataMember]
        public bool? AgreementOwnBankAccountListIndicator { get; set; }
        [DataMember]
        public int StatusID { get; set; }   
        [DataMember]
        public int BankID { get; set; }
        [DataMember]
        public int EntityID { get; set; }
        [DataMember]
        public string AbbreviatedReference { get; set; }
        [DataMember]
        public string ACBUserCode { get; set; }
        [DataMember]
        public string ControlGLAccountNumber { get; set; }
        [DataMember]
        public string BranchName { get; set; }
        [DataMember]
        public string BranchNumber { get; set; }
        [DataMember]
        public string ShortDescription { get; set; }
        [DataMember]
        public bool? IsOwnBankAcc { get; set; }
        [DataMember]
        public string StatusIDValue { get; set; }
        [DataMember]
        public bool? IsSweepAccount { get; set; }
        [DataMember]
        public int EntityTypeID { get; set; }
        [DataMember]
        public int? AutoAllocateDepositQuoteSubAccountID { get; set; }
        [DataMember]
        public int? AutoAllocateCutOff { get; set; }
        [DataMember]
        public int? B2BUserID { get; set; }
        [DataMember]
        public string CreditorsControlAccountNumber { get; set; }
        [DataMember]
        public int LinkedBankAccountXpressEntityID { get; set; }
        [DataMember]
        public string TransactionalBankAccountTypeCode { get; set; }
    }
}