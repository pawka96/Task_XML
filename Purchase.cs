using System.ComponentModel.DataAnnotations;

namespace Task_XML
{
    public class Purchase
    {

        [Key]
        public int Purchase_id { get; set; }

        public int Customer_id { get; set; }

        public DateOnly Date { get; set; }

        public double Summarize { get; set; }
    }
}
