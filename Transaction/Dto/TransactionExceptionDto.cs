using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public class TransactionExceptionDto : TrackableDto
    {
        [DataMember]
        public Int32 TransactionExceptionID { get; set; }
        [DataMember]
        public Int32 TransactionID { get; set; }
        [DataMember]
        public Int32 ExceptionMessageID { get; set; }
        [DataMember]
        public ExceptionMessage ExceptionMessage { get; set; }
    }
}