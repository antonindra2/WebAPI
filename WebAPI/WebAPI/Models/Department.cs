using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Department
    {
        public Department()
        {

        }

        public Department(int id, string name)
        {
            DeptId = id;
            Name = name;
          
        }
        
        [Key]
        public int DeptId { get; set; }
        public string Name { get; set; }
        

    }
}