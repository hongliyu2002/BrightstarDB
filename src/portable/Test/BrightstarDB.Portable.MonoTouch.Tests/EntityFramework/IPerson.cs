using System;
using System.Collections.Generic;
using BrightstarDB.EntityFramework;

namespace BrightstarDB.Portable.MonoTouch.Tests.EntityFramework
{
    [Entity("http://www.example.org/schema/Person")]
    public interface IPerson
    {
        string Id { get; }
        string Name { get; set; }
        DateTime? DateOfBirth { get; set; }
        int Age { get; set; }
        int Salary { get; set; }
        IPerson Mother { get; set; }
        IPerson Father { get; set; }
        ICollection<IPerson> Friends { get; set; }
        IAnimal Pet { get; set; }

        ISkill MainSkill { get; set; }

        [PropertyType("skill")]
        ICollection<ISkill> Skills { get; set; }

        IDepartment Department { get; set; }

        int EmployeeId { get; set; }

        IJobRole JobRole { get; set; }

        ICollection<Uri> Websites { get; set; }
    }
}
