using System.ComponentModel.DataAnnotations;

namespace contracted.Models
{
    public class Job
    {

        public int Id { get; set; }
        public int ContractorId { get; set; }
        [Required]
        public int CompanyId { get; set; }

    }
}