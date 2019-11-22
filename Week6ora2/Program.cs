using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ora2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pers1 = new Person("Ana",24);
            Person pers2 = new Person("Ioana", null);

            Console.WriteLine(pers1);
            Console.WriteLine(pers2);

            /* Student stud1 = new Student("Andrei Matei Popescu", "Pacurari 45", "andreimatei@yahoo.com", "0753423478", Specialty.ENG, University.Mecanichal, Faculty.AC);
             Student stud2 = new Student("Andrei Matei Popescu", "Pacurari 45", "andreimatei@yahoo.com", "0753423478", Specialty.ENG, University.Mecanichal, Faculty.AC);

             //Student empty = null;

             Student stud3 = new Student("Ilinca Maria Ionescu", "Canta 55", "ilincamaria@gmail.com", "7884554643", Specialty.IT, University.Medicine, Faculty.LITERATURE);

             Student[] students = new Student[3];
             students[0] = stud1;
             students[1] = stud2;
             students[2] = stud3;



             foreach (var element in students)
             {
                 Console.WriteLine(element);
             }
             Console.ReadLine();

             Student cloned = stud1.Clone();
             Console.WriteLine("Cloned: ");
             Console.WriteLine(cloned);

             int compareStudents = stud1.CompareTo(stud3);
             Console.WriteLine("Compare result: " + compareStudents);
         

           Console.WriteLine(stud1.GetHashCode());
           Console.WriteLine(stud3.GetHashCode());

           Console.WriteLine(stud1.Equals(stud2));
           Console.WriteLine(stud3.Equals(stud1));

           Console.WriteLine(stud1 == stud2);
           Console.WriteLine(stud1 == empty);
           Console.WriteLine(stud3 == stud1);

           Console.WriteLine(stud3 != stud1);
           Console.WriteLine(stud1 != stud2);

           var stud4 = (Student)stud3.Clone();
           Console.WriteLine(stud4 == stud3);
             */
        }
    }
    
}
