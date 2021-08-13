using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    [Serializable]
    public class Trainee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SpartaNo { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public override string ToString()
        {
            return $"{SpartaNo} - {FullName}";
        }
    }
}
