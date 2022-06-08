using System;
using System.Collections.Generic;

namespace IndustryTitan
{
    public class TaffyFactory : IFactory<Confectioner>
    {
        public List<Confectioner> employees { get; set; } = new List<Confectioner>();

        public int MinEmployeeCount{get;set;}
        public int MaxEmployeeCount{get;set;}

        List<Confectioner> EmployeeList = new List<Confectioner>(){};


        /*
            Compiler error. Can't convert type Confectioner to type SteelWorker.
        */
        public void HireEmployee (Confectioner employee)
        {
            EmployeeList.Add(employee);
        }

        public void HireEmployees(List<Confectioner> employeesToAdd)
        {
            foreach(Confectioner employee in employeesToAdd)
            {
                EmployeeList.Add(employee);
            }
        }
    }

}