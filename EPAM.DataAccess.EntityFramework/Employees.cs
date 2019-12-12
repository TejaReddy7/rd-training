using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.DataAccess.EntityFramework
{
    public class Employees
    {
        //private string stream;

        //public EmployeesTable(int? id, string firstName, string lastName, DateTime dOB, int genderId, string batch, string stream, int quarterId)
        //{
        //    Id = id;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    DOB = dOB;
        //    GenderId = genderId;
        //    Batch = batch;
        //    StreamId = stream;
        //    QuarterId = quarterId;
        //}

        [Key]
        public int? Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        [Required]
        public int GenderId { get; set; }
        [Required]
        public string Batch { get; set; }
        [Required]
        public string StreamId { get; set; }
        [Required]
        public int QuarterId { get; set; }
        
        //public string Gender { get; set; }
        //[Required]
        //public string Quarter { get; set; }

    }
}
