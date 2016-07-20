using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FC.Model.Enum;

namespace FC
{
    public abstract class Person
    {
        public abstract string FirstName { get; set; }
        public abstract string FamilyName { get; set; }
        public abstract Gender Gender { get; }
    }
}
