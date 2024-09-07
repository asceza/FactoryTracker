using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryTracker
{
    /// <summary>
    /// Сотрудник
    /// </summary>
    public class Employee
    {
        public uint ID { get; set; }
        public string FullName { get; set; }
        
        /// <summary>
        /// Должность
        /// </summary>
        public string JobPosition { get; set; }


        public Employee(uint id, string fullName, string jobPosition)
        {
            ID = id;
            FullName = fullName;
            JobPosition = jobPosition;
        }

    }
}
