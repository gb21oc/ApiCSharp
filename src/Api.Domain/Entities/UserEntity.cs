using System;
//using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public class UserEntity: BaseEntity // UserEntiy inherit  BaseEntity
    {
        public string Name { get; set; }

        //[DataType(DataType.EmailAddress, ErrorMessage = "Invalid email format")]
        public string Email { get; set; }
    }
}
