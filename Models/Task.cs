using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace MoneyApp_Api.Models
{
    public class TaskModel
    {
        public int Id { get; set; } 

        public string? Name { get; set; }

        public string? Description { get; set; }

        public  bool Completed { get; set; }
    }
}
