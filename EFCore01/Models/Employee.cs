using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore01.Models
{
    // model class
    // poco class 
    // plain old CLR object
    // represent the table in database
    // has properties that represent the columns in database table 
    internal class Employee 
    {
        #region By convention 
        // prublic property numeric type will be consider as primary key
        // By convention will consider this property as primary key
        // ID , Id , id or <ClassName>Id 
        public int Id { get; set; } // PK

        // string is mapped to NVarchar(max) allow null by default
        public string? EmpName { get; set; }


        //Value type s (int, decimal, DateTime) are mapped to NOT NULL columns by default 
        // decimal is mapped to decimal(18,2) by default
        public decimal Salary { get; set; }


        // value type allow null
        // will map to int.
        public int Age { get; set; } 
        #endregion
    }
}
