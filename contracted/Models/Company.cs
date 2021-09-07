using System.ComponentModel.DataAnnotations;

namespace contracted.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int EmployeeSize { get; set; }
        public int NetWorth { get; set; }
    }

    public class JobViewModel {
        public int jobId { get; set; }
    }
}