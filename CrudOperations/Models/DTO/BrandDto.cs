﻿namespace CrudOperations.Models.DTO
{
    public class BrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<UserDto> UsersDtoList;
    }
}
