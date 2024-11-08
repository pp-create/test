using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class Item
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double price { get; set; }
        public int idmain { get; set; }
        public int quanity { get; set; }

    }
}
