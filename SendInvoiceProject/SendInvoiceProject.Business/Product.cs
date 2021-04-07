using System.ComponentModel.DataAnnotations;

namespace SendInvoiceProject.Business
{
    public class Product
    {
        [Key]
        public int id { get; set; }
        public string displayName { get; set; }
        public float pricePerQuantity { get; set; }
        public int taxPercentPerQuantity { get; set; }
        public bool active { get; set; }
    }
}