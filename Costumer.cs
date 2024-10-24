using System.ComponentModel.DataAnnotations;

namespace Task_XML
{
    public class Customer
    {

        [Key]
        public int Cutomer_id { get; set; } 

        public string F_name { get; set; }  

        public string L_name { get; set; }  

    }
}
