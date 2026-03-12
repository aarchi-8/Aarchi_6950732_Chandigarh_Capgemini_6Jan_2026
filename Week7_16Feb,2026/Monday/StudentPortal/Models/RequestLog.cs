using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StudentPortal.Models
{
    [Table("RequestLogs")]
    public class RequestLog
    {
        [Key]
        public string Url { get; set; }
        public long ExecutionTime { get; set; }
    }
}
