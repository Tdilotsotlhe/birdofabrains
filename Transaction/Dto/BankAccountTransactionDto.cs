using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public class BankAccountTransactionDto : TrackableDto
    {
        public BankAccountTransactionDto()
        {
        } 
        [DataMember]
        public string ReasonCode { get; set; } 
        [DataMember]
        public string FormattedStmtStmtNo { get; set; }  
        [DataMember]
        public int BankAccountTransactionID { get; set; }
        [DataMember]
        public int BankAccountID { get; set; }
        [DataMember]
        public int? BankAccountTransactionTypeID { get; set; }
        [DataMember]
        public string StmtStmtDate { get; set; }
        [DataMember]
        public string StmtPrevDate { get; set; }
        [DataMember]
        public Nullable<decimal> StmtPrevBal { get; set; }
        [DataMember]
        public string StmtPrevBalDC { get; set; }
        [DataMember]
        public Nullable<decimal> StmtCurrBal { get; set; }
        [DataMember]
        public string StmtCurrBalDC { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTotCrNo { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTotCrAmt { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTotDrNo { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTotDrAmt { get; set; }
        [DataMember]
        public Nullable<decimal> StmtStmtNo { get; set; }
        [DataMember]
        public string StmtSfInd { get; set; }
        [DataMember]
        public Nullable<decimal> StmtSfFlat { get; set; }
        [DataMember]
        public Nullable<decimal> StmtSfMin { get; set; }
        [DataMember]
        public Nullable<decimal> StmtSfPer { get; set; }
        [DataMember]
        public Nullable<decimal> StmtSfMax { get; set; }
        [DataMember]
        public Nullable<decimal> StmtAnnRate { get; set; }
        [DataMember]
        public string StmtCustName { get; set; }
        [DataMember]
        public Nullable<decimal> StmtVatAmt { get; set; }
        [DataMember]
        public string StmtLangDesc { get; set; }
        [DataMember]
        public string StmtVersion { get; set; }
        [DataMember]
        public Nullable<decimal> StmtCompany { get; set; }
        [DataMember]
        public string StmtProduct { get; set; }
        [DataMember]
        public Nullable<decimal> StmtBranch { get; set; }
        [DataMember]
        public string StmtAccNo { get; set; }
        [DataMember]
        public DateTime? StmtProcDate { get; set; }
        [DataMember]
        public Nullable<decimal> StmtRecSeq { get; set; }
        [DataMember]
        public string StmtRecTyp { get; set; }
        [DataMember]
        public DateTime? StmtEffDate { get; set; }
        [DataMember]
        public DateTime? StmtTxPostDate { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTranCode { get; set; }
        [DataMember]
        public Nullable<decimal> StmtRule { get; set; }
        [DataMember]
        public Nullable<decimal> StmtAmount { get; set; }
        [DataMember]
        public string StmtDrCrInd { get; set; }
        [DataMember]
        public string StmtRevInd { get; set; }
        [DataMember]
        public string StmtCategory { get; set; }
        [DataMember]
        public string StmtSubCategory { get; set; }
        [DataMember]
        public string StmtSrcSystem { get; set; }
        [DataMember]
        public Nullable<decimal> StmtTxnBranch { get; set; }
        [DataMember]
        public Nullable<decimal> StmtIDNo { get; set; }
        [DataMember]
        public Nullable<decimal> StmtServFee { get; set; }
        [DataMember]
        public string StmtServDC { get; set; }
        [DataMember]
        public Nullable<decimal> StmtCkSerNo { get; set; }
        [DataMember]
        public string StmtTxnNarrative { get; set; }
        [DataMember]
        public string Reserved { get; set; }
        [DataMember]
        public Nullable<decimal> StmtClcBranch { get; set; }
        [DataMember]
        public string StmtTranType { get; set; }
        [DataMember]
        public string BranchNumber { get; set; }
        [DataMember]
        public string BranchName { get; set; }
        [DataMember]
        public string StmtReference { get; set; }
        [DataMember]
        public string BucketPeriod { get; set; }
        [DataMember]
        public string QuoteSubAccountShortName { get; set; }
        [DataMember]
        public string InterestGroupShortName { get; set; }
        [DataMember]
        public string QuoteName { get; set; }
        [DataMember]
        public string EntityName { get; set; }
        [DataMember]
        public string BankTransactionType { get; set; }
        [DataMember]
        public string BankAccountTransactionStatus { get; set; }
        [DataMember]
        public string BankAccountTransactionSubStatus { get; set; }
        [DataMember]
        public BankAccountDto BankAccount { get; set; }
        [DataMember]
        public BankAccountTransactionTypeDto BankAccountTransactionType { get; set; }
        [DataMember]
        public TransactionsDto Transactions { get; set; }
        [DataMember]
        public IEnumerable<BankAccountTransactionTypeDto> BankAccountTransactionTypes { get; set; }
        [DataMember]
        public bool? SplitDeposit { get; set; }
        [DataMember]
        public bool? IsPostedToPastel { get; set; }
        [DataMember]
        public int? PreviousBankAccountTransactionTypeID { get; set; }
        [DataMember]
        public int? BankAccountStatementID { get; set; }
        [DataMember]
        public int BankAccountTransactionStatusID { get; set; }
        [DataMember]
        public int? BankAccountTransactionSubStatusID { get; set; }
        [DataMember]
        public string ReasonDescription { get; set; }      
        [DataMember]
        public string ProcDate { get; set; }    
        [DataMember]
        public string SubCategoryDescription { get; set; }  
        [DataMember]
        public string BankAccountDescription { get; set; }  
        [DataMember]
        public Guid? UserID { get; set; }    
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public Nullable<DateTime> ReconciledDate { get; set; }
        [DataMember]
        public Nullable<DateTime> AllocatedDate { get; set; }
        [DataMember]
        public int? BucketID { get; set; }
        [DataMember]
        public bool IsCreatedInternally { get; set; }
        [DataMember]
        public int? ParentBankAccountTransactionID { get; set; }
        [DataMember]
        public string InternalReference { get; set; }
        [DataMember]
        public string StmtCkSerNoFormatted { get; set; } 
        //public BankAccountTransactionAuditDto CloneToBankAccountTransactionAudit()
        //{
        //    var bankAccountTransactionAuditDto = new BankAccountTransactionAuditDto();
        //    bankAccountTransactionAuditDto.BankAccountID = BankAccountID;
        //    bankAccountTransactionAuditDto.BankAccountTransactionTypeID = BankAccountTransactionTypeID;
        //    bankAccountTransactionAuditDto.BankAccountStatementID = BankAccountStatementID;
        //    bankAccountTransactionAuditDto.StmtCompany = StmtCompany;
        //    bankAccountTransactionAuditDto.StmtProduct = StmtProduct;
        //    bankAccountTransactionAuditDto.StmtBranch = StmtBranch;
        //    bankAccountTransactionAuditDto.StmtAccNo = StmtAccNo;
        //    bankAccountTransactionAuditDto.StmtProcDate = StmtProcDate;
        //    bankAccountTransactionAuditDto.StmtRecSeq = StmtRecSeq;
        //    bankAccountTransactionAuditDto.StmtRecTyp = StmtRecTyp;
        //    bankAccountTransactionAuditDto.StmtEffDate = StmtEffDate;
        //    bankAccountTransactionAuditDto.StmtTxPostDate = StmtTxPostDate;
        //    bankAccountTransactionAuditDto.StmtTranCode = StmtTranCode;
        //    bankAccountTransactionAuditDto.StmtRule = StmtRule;
        //    bankAccountTransactionAuditDto.StmtAmount = StmtAmount;
        //    bankAccountTransactionAuditDto.StmtDrCrInd = StmtDrCrInd;
        //    bankAccountTransactionAuditDto.StmtRevInd = StmtRevInd;
        //    bankAccountTransactionAuditDto.StmtCategory = StmtCategory;
        //    bankAccountTransactionAuditDto.StmtSubCategory = StmtSubCategory;
        //    bankAccountTransactionAuditDto.StmtSrcSystem = StmtSrcSystem;
        //    bankAccountTransactionAuditDto.StmtTxnBranch = StmtTxnBranch;
        //    bankAccountTransactionAuditDto.StmtIDNo = StmtIDNo;
        //    bankAccountTransactionAuditDto.StmtServFee = StmtServFee;
        //    bankAccountTransactionAuditDto.StmtServDC = StmtServDC;
        //    bankAccountTransactionAuditDto.StmtCkSerNo = StmtCkSerNo;
        //    bankAccountTransactionAuditDto.StmtTxnNarrative = StmtTxnNarrative;
        //    bankAccountTransactionAuditDto.Reserved = Reserved;
        //    bankAccountTransactionAuditDto.StmtClcBranch = StmtClcBranch;
        //    bankAccountTransactionAuditDto.StmtTranType = StmtTranType;
        //    bankAccountTransactionAuditDto.StmtReference = StmtReference;
        //    bankAccountTransactionAuditDto.StmtVersion = StmtVersion;
        //    bankAccountTransactionAuditDto.BankAccountTransactionStatusID = BankAccountTransactionStatusID;
        //    bankAccountTransactionAuditDto.BankAccountTransactionSubStatusID = BankAccountTransactionSubStatusID;
        //    bankAccountTransactionAuditDto.SplitDeposit = SplitDeposit;
        //    bankAccountTransactionAuditDto.IsPostedToPastel = IsPostedToPastel;
           
        //    return bankAccountTransactionAuditDto;
        //}

        //dont implement icloneable
        public BankAccountTransactionDto Clone()
        {
            var bankAccountTransactionDtoClone = new BankAccountTransactionDto();
            bankAccountTransactionDtoClone.BankAccountID = BankAccountID;
            bankAccountTransactionDtoClone.BankAccountTransactionTypeID = BankAccountTransactionTypeID;
            bankAccountTransactionDtoClone.BankAccountStatementID = BankAccountStatementID;
            bankAccountTransactionDtoClone.StmtCompany = StmtCompany;
            bankAccountTransactionDtoClone.StmtProduct = StmtProduct;
            bankAccountTransactionDtoClone.StmtBranch = StmtBranch;
            bankAccountTransactionDtoClone.StmtAccNo = StmtAccNo;
            bankAccountTransactionDtoClone.StmtProcDate = StmtProcDate;
            bankAccountTransactionDtoClone.StmtRecSeq = StmtRecSeq;
            bankAccountTransactionDtoClone.StmtRecTyp = StmtRecTyp;
            bankAccountTransactionDtoClone.StmtEffDate = StmtEffDate;
            bankAccountTransactionDtoClone.StmtTxPostDate = StmtTxPostDate;
            bankAccountTransactionDtoClone.StmtTranCode = StmtTranCode;
            bankAccountTransactionDtoClone.StmtRule = StmtRule;
            bankAccountTransactionDtoClone.StmtAmount = StmtAmount;
            bankAccountTransactionDtoClone.StmtDrCrInd = StmtDrCrInd;
            bankAccountTransactionDtoClone.StmtRevInd = StmtRevInd;
            bankAccountTransactionDtoClone.StmtCategory = StmtCategory;
            bankAccountTransactionDtoClone.StmtSubCategory = StmtSubCategory;
            bankAccountTransactionDtoClone.StmtSrcSystem = StmtSrcSystem;
            bankAccountTransactionDtoClone.StmtTxnBranch = StmtTxnBranch;
            bankAccountTransactionDtoClone.StmtIDNo = StmtIDNo;
            bankAccountTransactionDtoClone.StmtServFee = StmtServFee;
            bankAccountTransactionDtoClone.StmtServDC = StmtServDC;
            bankAccountTransactionDtoClone.StmtCkSerNo = StmtCkSerNo;
            bankAccountTransactionDtoClone.StmtTxnNarrative = StmtTxnNarrative;
            bankAccountTransactionDtoClone.Reserved = Reserved;
            bankAccountTransactionDtoClone.StmtClcBranch = StmtClcBranch;
            bankAccountTransactionDtoClone.StmtTranType = StmtTranType;
            bankAccountTransactionDtoClone.StmtReference = StmtReference;
            bankAccountTransactionDtoClone.StmtVersion = StmtVersion;
            bankAccountTransactionDtoClone.BankAccountTransactionStatusID = BankAccountTransactionStatusID;
            bankAccountTransactionDtoClone.BankAccountTransactionSubStatusID = BankAccountTransactionSubStatusID;
            bankAccountTransactionDtoClone.SplitDeposit = SplitDeposit;
            bankAccountTransactionDtoClone.IsPostedToPastel = IsPostedToPastel;
            bankAccountTransactionDtoClone.IsCreatedInternally = IsCreatedInternally;
            bankAccountTransactionDtoClone.ParentBankAccountTransactionID = ParentBankAccountTransactionID;

            return bankAccountTransactionDtoClone;
        }
    }
}