using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public class TransactionDto : TrackableDto, ITransactionException, ITransactionBatch, ICDVValidation
    {
        public TransactionDto()
        {
            Exceptions = new List<ExceptionMessageDto>();
            TransactionExceptions = new List<TransactionExceptionDto>();
            Transactions = new List<TransactionDto>();
            Notes = new List<NoteDto>();
            LineId = null;
        }
        [DataMember]
        public int ExceptionCount { get; set; } 
        [DataMember]
        public int SplitFileIndex { get; set; }
        [DataMember]
        public int SplitFileCount { get; set; }
        [DataMember]
        public int[] transactionIDs { get; set; }
        [DataMember]
        public int TransactionID { get; set; }
        [DataMember]
        public int EntityID { get; set; }
        [DataMember]
        public int TransactionTypeID { get; set; }
        [DataMember]
        public Nullable<int> TransactionSubTypeID { get; set; }
        [DataMember]
        public int OriginalBankAccountTypeID { get; set; }  
        [DataMember]
        public int TransactionStatusID { get; set; }
        [DataMember]
        public long CDVId { get; set; }
        [DataMember]
        public string ErrorCode { get; set; }
        [DataMember]
        public Nullable<int> Remainder { get; set; }
        [DataMember]
        public int BucketID { get; set; }
        
        private int? _bankAccountTypeID;
        [DataMember]
        public int? BankAccountTypeID
        {
            get { return _bankAccountTypeID; }
            set { _bankAccountTypeID = value; }
            }
        [DataMember]
        public string AccountNumberPadded { get; set; } 
        [DataMember]
        public int PHSBankAccountType { get; set; }     
        [DataMember]
        public DateTime CreationDate { get; set; }
     
        [CsvColumn("ActionDate")]
        [DataMember]
        public DateTime ActionDate { get; set; }
        [CsvColumn("TransactionStatus", "TransactionStatusID")]
        [DataMember]
        public string TransactionStatus { get; set; }
        private string _branchNumber;
        [CsvColumn("BranchNumber")]
        [DataMember]
        public string BranchNumber
        {
            get { return _branchNumber; }
            set
            {
                _branchNumber = value;
                BranchCode = _branchNumber;
            }
        }
        [DataMember]
        public string BranchCode { get; set; } 
        [CsvColumn("TransactionType", "TransactionTypeID")]
        [DataMember]
        public string TransactionType { get; set; }
        [CsvColumn("TransactionSubType", "TransactionSubTypeID")]
        [DataMember]
        public string TransactionSubType { get; set; }     
        [CsvColumn("AccountHolder")]
        [DataMember]
        public string AccountHolder { get; set; }
        private string _accountNumber;
        [CsvColumn("AccountNumber")]
        [DataMember]
        public string AccountNumber 
        {
            get { return _accountNumber; }
            set 
            {
                if (!string.IsNullOrEmpty(value))   
                {
                    _accountNumber = value;
                    if (_accountNumber.Length < 11)
                        AccountNumberPadded = _accountNumber.PadLeft(11, '0');
                    else
                        AccountNumberPadded = _accountNumber;
                }
            }
        }

         

        [CsvColumn("TransactionReference")]
        [DataMember]
        public string TransactionReference { get; set; }
        [CsvColumn("Amount")]
        [DataMember]
        public double Amount { get; set; }
        private string _serviceChannelDescription;
        [CsvColumn("Service Channel", "ServiceChannelID")]
        [DataMember]
        public string ServiceChannelDescription
        {
            get
            {
                return _serviceChannelDescription;
            }
            set
            {
                _serviceChannelDescription = value;
            }
        }
        private string _serviceTypeDescription;
        [CsvColumn("Service Type", "ServiceTypeID")]
        [DataMember]
        public string ServiceTypeDescription
        {
            get
            {
                return _serviceTypeDescription;
            }
            set
            {
                _serviceTypeDescription = value;
            }
        }
        [CsvColumn("Comment")]
        [DataMember]
        public string Comment { get; set; }
        [DataMember]
        public int? ServiceChannelID { get; set; }
        [DataMember]
        public int? ServiceTypeID { get; set; }
        [DataMember]
        public string DrCrInd { get; set; }
        [DataMember]
        public string UniqueIdentifier { get; set; }
        [DataMember]
        public int? NAEDOTrackingDaysID { get; set; }
        [DataMember]
        public Nullable<int> BusinessEventTaskID { get; set; }
        [DataMember]
        public Nullable<int> ACBBatchID { get; set; }
        [DataMember]
        public Nullable<int> BankAccountTransactionID { get; set; }
        [DataMember]
        public Nullable<int> InternalRejectionReasonID { get; set; }
        
        [DataMember]
        public bool? ForcedReferencing { get; set; }
        [DataMember]
        public Nullable<int> ClientImportFileID { get; set; }
        [DataMember]
        public Nullable<bool> ChargeClientForRecall { get; set; }
        [DataMember]
        public Nullable<int> ACBReasonCodeID { get; set; }
        [DataMember]
        public Nullable<int> ExportFileID { get; set; }
        [DataMember]
        public string DrCrIndicator { get; set; }
        [DataMember]
        public Nullable<int> AuthorisationLevelID { get; set; }
        [DataMember]
        public int AuthStartLevel { get; set; }
        [DataMember]
        public DateTime? ReverseDate { get; set; }

        [DataMember]
        public int Authorize { get; set; }
        [DataMember]
        public string CsvTransaction { get; set; }
        [DataMember]
        public int? JournalID { get; set; }
        [DataMember]
        public string LastUpdatedUser { get; set; }
        [DataMember]
        public Guid UserId { get; set; }
        [DataMember]
        public List<TransactionDto> Transactions { get; set; }
        [DataMember]
        public IEnumerable<EntityBankAccountTransactionDto> BankReconTransactions { get; set; }
        [DataMember]
        public int PageNum { get; set; }
        [DataMember]
        public bool? RealTime { get; set; }
        [DataMember]
        public int BankAccountID { get; set; }
        [DataMember]
        public byte[] InstructionFile { get; set; }
        [DataMember]
        public string InstructionFileString { get; set; }
        [DataMember]
        public string InstructionFileWebType { get; set; }
        [DataMember]
        public string InstructionFileType { get; set; }
        [DataMember]
        public bool HasFile { get; set; }
        [DataMember]
        public int EntityBankAccountTransactionID { get; set; }
        [DataMember]
        public bool IgnoreException { get; set; }
        [DataMember]
        public string InternalReference { get; set; }
        [DataMember]
        public List<ExceptionMessageDto> Exceptions { get; set; }
        [DataMember]
        public ExceptionMessageDto[] ExceptionList { get; set; }  
        [DataMember]
        public List<TransactionExceptionDto> TransactionExceptions { get; set; }
        [DataMember]
        public int AuthorizationLevel { get; set; } 
        [DataMember]
        public bool IsExternalSingleRecall { get; set; }    
        [DataMember]
        public bool IsExternalBatchRecall { get; set; } 
        [DataMember]
        public bool IsPaymentReversal { get; set; } 
        [DataMember]
        public int? ParentTransactionTypeID { get; set; }   
        [DataMember]
        public int? OriginalServiceTypeID { get; set; } 
        [DataMember]
        public int? ACBErrorCodeID { get; set; }    
        [DataMember]
        public int? ClientExportFileID { get; set; }    
        [DataMember]
        public List<NoteDto> Notes { get; set; }
        public int RuleFlow { get; set; }
        public bool IsDebit { get; set; }
        public int TempID { get; set; }
        [DataMember]
        public int? NominatedPaymentPartyID { get; set; }

        [DataMember]
        public double? AggregateProcessedRatio { get; set; }

        [DataMember]
        public double? AggregateExpectedRatio { get; set; }

        [DataMember]
        public double? ItemProcessedRatio { get; set; }

        [DataMember]
        public double? ItemExpectedRatio { get; set; }

        [DataMember]
        public TransactionDto DebitJournalTransaction { get; set; }

        [DataMember]
        public DateTime? ImportDateTime { get; set; }

        [DataMember]
        public bool IsAccountTypeAdjusted { get; set; }

        [DataMember]
        public int? ACBServiceTypeID { get; set; }

        [DataMember]
        public int? QuoteID { get; set; }

        [DataMember]
        public int? QuoteSubAccountID { get; set; }

        [DataMember]
        public int? QuoteInterestCalculationGroupID { get; set; }
        [DataMember]
        public string EntityName { get; set; }
        [DataMember]
        public string AgreementName { get; set; }
        [DataMember]
        public string InterestGroupName { get; set; }
        [DataMember]
        public string SubAccountName { get; set; }
        [DataMember]
        public string CollectionPeriod { get; set; }
        [DataMember]
        public DateTime CollectionPeriodStartDate { get; set; }
        [DataMember]
        public DateTime CollectionPeriodEndDate { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public int? ParentTransactionID { get; set; }
        [DataMember]
        public bool StartTransactionWorkflow { get; set; }
        [DataMember]
        public bool IsPaymentTypeNotAllowed { get; set; }  
        [DataMember]
        public string FormattedActionDate { get; set; } 
        [DataMember]
        public string BankTransactionReference { get; set; }    
        [DataMember]
        public Guid? ImportExceptionIdentifier { get; set; }    
        [DataMember]
        public int? ServiceID { get; set; }  
        [DataMember]
        public BankAccountTransactionDto BankAccountTransaction { get; set; }

        [DataMember]
        public bool? subAccountCollectionsPrefixInd { get; set; }
        [DataMember]
        public bool? interestGroupCollectionsPrefixInd { get; set; }
        [DataMember]
        public string IsNominated { get; set; }
        [DataMember]
        public int BusinessEventTaskJsonID { get; set; }
        [DataMember]
        public int FileImportID { get; set; }
        [DataMember]
        public ClientImportFileDto ClientImportFile { get; set; }
        [DataMember]
        public bool? IsPostedToPastel { get; set; }
        [DataMember]
        public bool? IsNominatedParty { get; set; }
        [DataMember]
        public int? IsPassed { get; set; }
        private bool _passedCSV;
        [DataMember]
        public bool PassedCSV
        {
            get { return _passedCSV; }
            set 
            {
                if (IsPassed.HasValue)  
                {
                    _passedCSV = IsPassed.Value == 1 ? true : false;
                }
                else
                    _passedCSV = value; 
            }
        }     
       
        [DataMember]
        public Nullable<Guid> LineId { get; set; }    
        [DataMember]
        public Guid FileGroupId { get; set; }   
        [DataMember]
        public bool MustGotoLevel2 { get; set; }  
        [DataMember]
        public int? TransactionAuthStatusID { get; set; }    
        [DataMember]
        public int TransactionAuthorisationID { get; set; } 
        [DataMember]
        public int TransactionAuthStatusEventTaskID { get; set; }   
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int FTPSequence { get; set; }
        [DataMember]
        public bool IsPastActionDateRejected { get; set; }
        [DataMember]
        public string QuoteSubAccountUniqueIdentifier { get; set; }
    }
}