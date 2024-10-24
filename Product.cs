using System.ComponentModel.DataAnnotations;

namespace Task_XML
{
    public class Product
    {

        [Key]
        public int Product_id { get; set; }

        public string Title { get; set; }

        public double Cost { get; set; }
    }
}
