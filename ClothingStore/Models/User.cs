using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models
{
    public class User
    {
        [Key]
        public int IdUser { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Status { get; set; }
        public int IdAcc { get; set; }
        public Account Account { get; set; }
    }
}
