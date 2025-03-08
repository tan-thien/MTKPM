using System.ComponentModel.DataAnnotations;

namespace ClothingStore.Models
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public int IdCus { get; set; }
        public string StatusOrder { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime NgayGiao { get; set; }
        public string MoTa { get; set; }
        public int TongTien { get; set; }
        public Customer Customer { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
