using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crm.EntityLayer.Concrete
{
   public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [StringLength(50)]
        public string EmployeeName { get; set; }
     
        [StringLength(50)]
        public string EmployeeSurname { get; set; }

        [StringLength(100)]
        public string EmployeeMail { get; set; }

        [StringLength(50)]
        public string EmployeePassword { get; set; }

        [StringLength(5)]
        public string EmployeeGender { get; set; }

        [StringLength(50)]
        public DateTime EmployeeBirth{ get; set; }
    }
}
