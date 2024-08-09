namespace CrudOperations.Models.DTO
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeviceId { get; set; }
        public BrandDto Brand { get; set; }
    }
}
