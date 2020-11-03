using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Dimension_Data_MVC_CORE_Project2.Models
{
    public class HumanResource
    {
        [Key]
        public int id { get; set; }

        public float Age { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Business Travel")]
        public string BusinessTravel { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Department")]
        public string Department { get; set; }

        [DisplayName("Distance From Home")]
        public float DistanceFromHome { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Education Field")]
        public string EducationField { get; set; }

        [DisplayName("Employee Number")]
        public float EmployeeNumber { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Job Role")]
        public string JobRole { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }

        [DisplayName("Number of Companies Worked")]
        public float NumCompaniesWorked { get; set; }


        [Column(TypeName = "nvarchar(255)")]
        [Required]
        [DisplayName("Over Time")]
        public string OverTime { get; set; }

        [DisplayName("Total Working Years")]
        public float TotalWorkingYears { get; set; }

        [DisplayName("Training Times LastYear")]
        public float TrainingTimesLastYear { get; set; }

        [DisplayName("Years At Company")]
        public float YearsAtCompany { get; set; }

        [DisplayName("Years In Current Role")]
        public float YearsInCurrentRole { get; set; }

        [DisplayName("Years Since Last Promotion")]
        public float YearsSinceLastPromotion { get; set; }

        [DisplayName("Years With Current Manager")]
        public float YearsWithCurrManager { get; set; }
    }
}
