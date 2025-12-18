using System.ComponentModel.DataAnnotations;

namespace WebApp_building.DAL.Entities
{
    public class Ask
    {
        [Key]
        public int Id { get; set; }
        public string AskTitle { get; set; }
        public string AskAnswer { get; set; }
    }
}
