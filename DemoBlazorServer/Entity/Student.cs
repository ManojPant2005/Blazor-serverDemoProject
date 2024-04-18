using System.ComponentModel.DataAnnotations;

namespace CrudDemoBlazorServer.Entity
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? StudentName { get; set; }
        [Required]
        public int StudentAge { get; set;}
        [Required]
        public int Mobile { get; set;}
        [Required]
        public string? Subject { get; set; }
        [Required]
        public string? Fees { get; set;}
    }
}
