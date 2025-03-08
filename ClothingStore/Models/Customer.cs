using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models
{
    public class Customer
    {
        [Key]
        public int IdCus { get; set; }
        public string CusName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int IdUser { get; set; }
        public User User { get; set; }
    }
}
