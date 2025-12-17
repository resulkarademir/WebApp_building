using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class Feature
    {
        [Key]
        public int FeatureId { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Button { get; set; }
    }
}
