using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Image
    {
        [Key]
        public int ImageID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }

        public virtual ImageCategory ImageCategory { get; set; }
        public int ImageCategoryID { get; set; }
    }
}
