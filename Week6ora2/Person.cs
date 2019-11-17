using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ora2
{
  public   class Person
    {
        private string name;
        private Nullable<int> age;
        public Person(string nume, Nullable<int> varsta)
        {
            this.name = nume;
            this.age = varsta;

        }
        public override string ToString()
        {
            StringBuilder sir = new StringBuilder();
            sir.AppendLine("Nume" + this.name);
            if (age == null)
            {
                sir.AppendLine("Null");
            }
            else
            {
                sir.AppendLine("Age:" + this.age);
            }
            return sir.ToString();
        }
    }
}
