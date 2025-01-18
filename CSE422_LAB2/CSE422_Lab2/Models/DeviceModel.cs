using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSE422_Lab2.Models
{
    public class DeviceModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public String Status { get; set; }
        public DateTime DateOfEntry { get; set; }

        
    }
}
