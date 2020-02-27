using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public class ExceptionMessageDto : TrackableDto
    {
        [DataMember]
        public int TransactionID { get; set; }  

        [DataMember]
        public int ExceptionMessageID { get; set; }
        [DataMember]
        public int TransactionExceptionID { get; set; }
        [DataMember]
        public string ShortDescription { get; set; }
        [DataMember]
        public string LongDescription { get; set; }
        [DataMember]
        public string ExceptionCode { get; set; }
        [DataMember]
        public bool? InternalUserOnly { get; set; }
        [DataMember]
        public bool MustGotoLevel2 { get; set; }
        [DataMember]
        public bool IsNoteMandatoryOnCapture { get; set; }
        [DataMember]
        public bool IsNoteMandatoryOnLVL1 { get; set; }
        [DataMember]
        public bool IsNoteMandatoryOnLVL2 { get; set; }
        [DataMember]
        public bool IsNoteMandatoryOnLVLQC { get; set; }
        [DataMember]
        public Nullable<int> ExceptionMessageContextID { get; set; }
        [DataMember]
        public Guid? ImportExceptionIdentifier { get; set; }   

        [DataMember]
        public TransactionExceptionDto TransactionExceptionDto { get; set; }
    }
}