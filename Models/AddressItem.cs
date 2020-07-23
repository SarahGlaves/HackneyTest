using System;
namespace PostCode.Models
{
    public class AddressItem
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public PostCodeItem PostCode { get; set; }
    }
}
