using System;

namespace PostCode.Models
{
    public class PostCodeItem
    {
        public int Id { get; set; }
        public string PostCode { get; set; }
        public System.Collections.Generic.IList<AddressItem> AddressItems {get; set;}
    }
}
