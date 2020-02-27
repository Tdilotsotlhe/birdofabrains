using System;
using System.Runtime.Serialization;
namespace Xcelerate.Application.Tx.Dto
{

    [DataContract]
    public abstract class CachableDto : TrackableDto
    {
        private Dictionary<string, object> _parameters;

        public Dictionary<string, object> Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }
        public CachableDto()
        {
            _parameters = new Dictionary<string, object>();
        }

        [DataMember]
        public string ShortDescription { get; set; }
        [DataMember]
        public string LongDescription { get; set; }
        public string StoredProcedureName { get; set; } 
    }
}