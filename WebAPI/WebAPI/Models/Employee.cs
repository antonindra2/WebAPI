using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(int id, string name,int age)
        {
            EmpId = id;
            Name = name;
            Age = age;
        }
        [Key]
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        [ForeignKey("department")]
        public int DeptId { get; set; }

        public Department department { get; set; }
    }
}