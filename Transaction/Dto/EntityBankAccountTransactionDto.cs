using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    public class EntityBankAccountTransactionDto : TrackableDto
    {
        [DataMember]
        public Int32 EntityBankAccountTransactionID { get; set; }
        [DataMember]
        public Int32 BankAccountTransactionID { get; set; }
        [DataMember]
        public Int32 EntityID { get; set; }
        [DataMember]
        public Nullable<Int32> QuoteID { get; set; }
        [DataMember]
        public Nullable<Int32> QuoteInterestCalculationGroupID { get; set; }
        [DataMember]
        public Nullable<Int32> QuoteSubAccountID { get; set; }
        [DataMember]
        public Nullable<Int32> BucketID { get; set; }
        [DataMember]
        public Nullable<Int32> ServiceID { get; set; }
        [DataMember]
        public Nullable<Double> Amount { get; set; }
        [DataMember]
        public String BankTransactionReference { get; set; }
        [DataMember]
        public String Comment { get; set; }
        [DataMember]
        public string EntityName { get; set; }
        [DataMember]
        public string QuoteName { get; set; }
        [DataMember]
        public string QuoteInterestCalculationGroupName { get; set; }
        [DataMember]
        public string QuoteSubAccountName { get; set; }
        [DataMember]
        public string BucketName { get; set; }
        [DataMember]
        public DateTime ProcessedDate { get; set; }
        [DataMember]
        public string TransactionType { get; set; }
        [DataMember]
        public string InternalReference { get; set; }
        [DataMember]
        public string DrCrIndicator { get; set; }
        [DataMember]
        public string TransactionStatus { get; set; }
        [DataMember]
        public int TransactionStatusID { get; set; }
        [DataMember]
        public int? TransactionID { get; set; }
        [DataMember]
        public DateTime ActionDate { get; set; }
        [DataMember]
        public string AgreementName { get; set; }
        [DataMember]
        public string InterestGroupName { get; set; }
        [DataMember]
        public string SubAccountName { get; set; }
        [DataMember]
        public string CollectionPeriod { get; set; }
        [DataMember]
        public string AccountNumber { get; set; }
        [DataMember]
        public string AccountHolder { get; set; }
        [DataMember]
        public string TransactionReference { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string ProcessedDateFormatted { get; set; }

        [DataMember]
        public string FormattedActionDate { get; set; }
        [DataMember]
        public bool? IsPostedToPastel { get; set; } 
    }
}