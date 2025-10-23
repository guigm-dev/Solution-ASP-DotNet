using System.ComponentModel.DataAnnotations;
namespace Project_ASP_DotNet_MVC.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateRegister { get; set; }
        public bool Active { get; set; }
    }
}