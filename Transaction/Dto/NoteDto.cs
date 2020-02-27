using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    [Serializable]
    public class NoteDto : TrackableDto
    {
        public NoteDto()
        {
        }
        [DataMember]
        public int NoteID { get; set; }
        [DataMember]
        public int ClassTypeID { get; set; }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string ShortDescription { get; set; }
        [DataMember]
        public Nullable<int> EntityID { get; set; }
        [DataMember]
        public Guid? UserID { get; set; }
        [DataMember]
        public string LongDescription { get; set; }
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public string AvatarString { get; set; }
        [DataMember]
        public Nullable<int> TransactionExceptionID { get; set; }
        [DataMember]
        public Nullable<int> ExceptionMessageID { get; set; }
        [DataMember]
        public Nullable<int> AuthorisationLevelID { get; set; }
        [DataMember]
        public byte[] Avatar { get; set; }
        [DataMember]
        public string AvatarFileType { get; set; }  
        [DataMember]
        public int TransactionID { get; set; }  
        [DataMember]
        public Guid FileGroupId { get; set; }   
        [DataMember]
        public bool AttachToBatch { get; set; }
        [DataMember]
        public bool AttachToNPP { get; set; }
        [DataMember]
        public bool IsRejectNote { get; set; }
        [DataMember]
        public int? ClientImportFileID { get; set; } 
        [DataMember]
        public bool AttachToRecalled { get; set; }
        [DataMember]
        public int? NoteAttachmentID { get; set; }
        [DataMember]
        public string NoteAttachmentFileName { get; set; }
        [DataMember]
        public string FileInfo { get; set; }
        [DataMember]
        public byte[] FileBytes { get; set; }
        [DataMember]
        public string FileName { get; set; }
        [DataMember]
        public bool AttachToRejected { get; set; }
        [DataMember]
        public int[] IDList { get; set; }

    }
}