using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FC.Model.Enum;

namespace FC.Model
{
    public class Man : Person
    {
        private string _firstName;
        private string _familyName;
        public override string FamilyName
        {
            get
            {
                return _familyName;
            }

            set
            {
                _familyName = value;
            }
        }

        public override string FirstName
        {
            get
            {
                return _firstName;
            }

            set
            {
                _firstName = value;
            }
        }

        public override Gender Gender
        {
            get
            {
                return Gender.Male;
            }
        }

        public Man(string firstName, string familyName)
        {
            _firstName = firstName;
            _familyName = familyName;
        }
    }
}
