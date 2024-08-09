
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace CrudOperations.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int DeviceId { get; set; }




        
        [ForeignKey("DeviceId")]
        [JsonIgnore]
        public Brand Brand { get; set; }

    }
}
