using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension_Data_MVC_CORE_Project2.Models
{
    public class Manager
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Attrition")]
        public string Attrition { get; set; }

        [DisplayName("Daily Rate")]
        public float DailyRate { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Department")]
        public string Department { get; set; }

        [DisplayName("Employee Count")]
        public float EmployeeCount { get; set; }

        [DisplayName("Employee Number")]
        public float EmployeeNumber { get; set; }

        [DisplayName("Hourly Rate")]
        public float HourlyRate { get; set; }

        [DisplayName("Job Involvement")]
        public float JobInvolvement { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Job Role")]
        public string JobRole { get; set; }

        [DisplayName("Monthly Income")]
        public float MonthlyIncome { get; set; }



        [DisplayName("Monthly Rate")]
        public float MonthlyRate { get; set; }


        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Over Time")]
        public string OverTime { get; set; }

        [DisplayName("Percent Salary Hike")]
        public float PercentSalaryHike { get; set; }

        [DisplayName("Performance Rating")]
        public float PerformanceRating { get; set; }

        [DisplayName("Standard Hours")]
        public float StandardHours { get; set; }



}
}
