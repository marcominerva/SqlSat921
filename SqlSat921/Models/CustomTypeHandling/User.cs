using SqlSat921.Enums;

namespace SqlSat921.Models.CustomTypeHandling
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }
    }
}
