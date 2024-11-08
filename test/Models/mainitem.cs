using System.ComponentModel.DataAnnotations;

namespace test.Models
{
    public class mainitem
    {
        [Key]
        public int id { get; set; }
        public string Nmae { get; set; }

    }
}
