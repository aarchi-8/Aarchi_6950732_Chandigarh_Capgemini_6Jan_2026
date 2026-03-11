using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SampleCodeFirstInDotNETCoreMVC.Models
{
    [Table("TodoItemsTable")]
    public class TodoItem
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
