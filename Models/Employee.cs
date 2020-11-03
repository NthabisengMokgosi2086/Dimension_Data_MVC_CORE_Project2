using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension_Data_MVC_CORE_Project2.Models
{
    public class Employee
    {

        [Key]
        public int id { get; set; }

        public float Age { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Business Travel")]
        public string BusinessTravel { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Department")]
        public string Department { get; set; }

        [Required]
        [DisplayName("Education Field")]
        public float EducationField { get; set; }

        [DisplayName("Employee Number")]
        public float EmployeeNumber { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }


        [Required]
        [DisplayName("Hourly Rate")]
        public float HourlyRate { get; set; }


        [Required]
        [DisplayName("Job Satisfaction")]
        public float JobSatisfaction { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }

        [DisplayName("Monthly Income")]
        public float MonthlyIncome { get; set; }

        [DisplayName("Relationship Satisfaction")]
        public float RelationshipSatisfaction { get; set; }

        [DisplayName("Standard Hours")]
        public float StandardHours { get; set; }

        [DisplayName("Stock Option Level")]
        public float StockOptionLevel { get; set; }
}
}
