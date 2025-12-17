using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class NedenBiz
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
 
    }
}
