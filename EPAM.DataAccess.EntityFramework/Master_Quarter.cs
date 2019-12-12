using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPAM.DataAccess.EntityFramework
{
    public class Master_Quarter
    {
        [Key] public int Id { get; set; }
        public string Value { get; set; }
    }
}
