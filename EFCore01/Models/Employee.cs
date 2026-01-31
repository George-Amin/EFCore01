using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCore01.Models
{
    // model class
    // poco class 
    // plain old CLR object
    // represent the table in database
    // has properties that represent the columns in database table 
    public class Employee 
    {
        #region By convention 
        //// public property numeric type will be consider as primary key
        //// By convention will consider this property as primary key
        //// ID , Id , id or <ClassName>Id 
        //public int Id { get; set; } // PK

        //// string is mapped to NVarchar(max) allow null by default
        //public string? EmpName { get; set; }


        ////Value type s (int, decimal, DateTime) are mapped to NOT NULL columns by default 
        //// decimal is mapped to decimal(18,2) by default
        //public decimal Salary { get; set; }


        //// value type allow null
        //// will map to int.
        //public int Age { get; set; } 
        #endregion
        #region DataAnnotation
        /*        
                // PK
                [Key]
                public int Id { get; set; } // PK

                [Required]
                [Column("EmployeeName" , TypeName = "varchar")]
                [MaxLength(50, ErrorMessage = "max Length is 50 chars")]
                [MinLength(10, ErrorMessage = "min Length is 10 chars")]
                //[StringLength(50 , MinimumLength = 10)]
                //[Length(10 , 50)]
                public string? EmpName { get; set; }

                [Column("EmployeeSalary" , TypeName = "Decimal(10,2)")]
                public decimal Salary { get; set; }


                //int[] ages = int.ra;
                //[Range(18 , 60)] // range will not be mapped in database 
                [AllowedValues(21, 22,23)] // .will not be mapped in database
                [DeniedValues(16,17,18)] // .will not be mapped in database
                public int Age { get; set; }


                // .will not be mapped in database
                [Phone]
                [DataType(DataType.PhoneNumber)]
                public required string PhoneNumber { get; set; } // not allow null 
                [Required]
                [DataType(DataType.Password)]
                public string Password { get; set; }

                [Required]
                [EmailAddress]
                [DataType(DataType.EmailAddress)]
                public string EmailAddress { get; set; }

                [NotMapped]
                public int MyProperty { get; set; } // this prop will not mapped in database
        */
        #endregion

        #region Fluent API 
        public int EmpId { get; set; }
        public string  EmpName { get; set; }
        [Column("EmployeeSalary", TypeName = "Decimal(10,2)")]
        public decimal Salary { get; set; }


        //int[] ages = int.ra;
        //[Range(18 , 60)] // range will not be mapped in database 
        [AllowedValues(21, 22, 23)] // .will not be mapped in database
        [DeniedValues(16, 17, 18)] // .will not be mapped in database
        public int Age { get; set; }


        // .will not be mapped in database
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public required string PhoneNumber { get; set; } // not allow null 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [NotMapped]
        public int MyProperty { get; set; } // this prop will not mapped in database

        #endregion

    }
}
