using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Model
{
    public class TblEmployee
    {
        public int Id { get; set; }
        
        [StringLength(150)]
        public string? Name { get; set; }

        [StringLength(150)]
        public string? LastName { get; set; }

        [StringLength(250)]
        public string? Email { get; set; }
        public int Age { get; set; }
        public DateTime Doj { get; set; }
        [StringLength(20)]
        public string? Gender { get; set; }
        public int IsMarried { get; set; }
        public int IsActive { get; set; }
        public int DesignationID { get; set; }
        [NotMapped]   // not used as column in db
        public string? Designation { get; set; }

    }
}
