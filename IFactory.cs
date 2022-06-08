using System;
using System.Collections.Generic;

namespace IndustryTitan
{
    public interface IFactory<T>
    {
        int MinEmployeeCount{get;set;}
        int MaxEmployeeCount{get;set;}

        void HireEmployee(T employee);
        void HireEmployees(List<T> employees);
    }
}