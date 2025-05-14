using System.ComponentModel.DataAnnotations;

namespace BACapstoneProject.Server.Modles
{
    public class Role
    {
        [Required]
        public int RoleId { get; set; }
        public string RoleName { get; set; }

    }
}
