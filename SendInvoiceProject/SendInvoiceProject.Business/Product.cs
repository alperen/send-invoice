using System.ComponentModel.DataAnnotations;

namespace SendInvoiceProject.Business
{
    public class Product
    {
        [Key]
        public int id;
        public string displayName;
        public float pricePerQuantity;
        public int taxPercentPerQuantity;
        public bool active;
    }
}