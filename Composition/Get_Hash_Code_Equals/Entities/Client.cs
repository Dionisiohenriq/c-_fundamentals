using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Hash_Code_Equals.Entities
{
    public class Client
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client))
            {
                return false;
            }

            Client other = obj as Client;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
