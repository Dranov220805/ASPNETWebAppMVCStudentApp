using System.ComponentModel.DataAnnotations;

namespace ASPNETWebAppMVCStudentApp.Models
{
    public class tblUsers
    {
        [Key]
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        // Add other properties as needed
    }
}