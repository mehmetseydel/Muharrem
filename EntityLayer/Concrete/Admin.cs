using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }
        public string FullName  { get; set; }
        public string Email  { get; set; }
        public string Password { get; set; }
    }
}
