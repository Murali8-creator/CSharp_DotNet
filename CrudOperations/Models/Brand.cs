using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;


namespace CrudOperations.Models
{
    public class Brand
    {
        [Key]
        public int DeviceId { get; set; }

        public string? Name { get; set; }


        [JsonIgnore]
        public List<User> Users { get; set; } = new List<User>();

    }
}
