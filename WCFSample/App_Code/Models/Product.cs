using System.Runtime.Serialization;

namespace WCFSample.Models {
    [DataContract]
    public class Product {
        [DataMember]
        public int Id { get; set; }
        
        [DataMember]
        public string Name { get; set; }

        public float Price { get; set; }
    }
}