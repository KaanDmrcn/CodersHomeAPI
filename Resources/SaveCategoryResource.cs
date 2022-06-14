using System.ComponentModel.DataAnnotations;

namespace CodersHomeAPI.Resources
{
    public class SaveCategoryResource
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        public string ParentID { get; set; }
        public string CategoryName { get; set; }
    }
}
