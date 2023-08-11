using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Personal
    {
        [Key]
        public int PersonalID { get; set; }
        public string FullName { get; set; }
        public string Telephone { get; set; }
        public string ImageUrl { get; set; }
        //sosyal medyada ekletelirsin

    }
}
