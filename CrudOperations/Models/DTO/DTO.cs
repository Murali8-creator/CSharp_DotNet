namespace CrudOperations.Models.DTO
{
    
    public class UserDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DeviceId { get; set; }
        public BrandSimpleDTO Brand { get; set; }

        public override string ToString()
        {
            return $"UserDTO [Id={Id}, Name={Name}, DeviceId={DeviceId}, Brand={Brand}]";
        }
    }

    public class BrandDTO
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public List<UserSimpleDTO> Users { get; set; }

        public override string ToString()
        {
            return $"BrandDTO [Name={Name}, DeviceId={DeviceId}]";
        }
    }

    public class UserSimpleDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class BrandSimpleDTO
    {
        public int DeviceId { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"BrandSimpleDTO [DeviceId={DeviceId}, Name={Name}]";
        }
    }
}
