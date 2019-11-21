using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ora2
{
    public enum Specialty { IT, MATH, ENG, ITALY };
    public enum University { Arts, Medicine, Farmacy, Mecanichal };
    public enum Faculty { AC, INFO, LITERATURE, MANAGEMENT };

    public class Student : ICloneable, IComparable<Student>
    {

        public string[] Names;
        public string First
        {
            get { return Names[0]; }
        }
        public string Middle
        {
            get { return Names[1]; }
        }
        public string LastName
        {
            get { return Names[2]; }
        }

        public string PrintNames
        {
            get
            {
                return $"{this.First} {this.Middle} {this.LastName}";
            }
        }



        public string Address { get; set; }
        public string Email { get; set; }
        public string Course { get; set; }
        public string Phone { get; set; }
        public string SSN { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        public Student(string name, string address, string email, string course, string phone, string ssn,  Specialty specialty, University university, Faculty faculty)
        {
            Names = name.Split(' ');
            this.Address = address;
            this.Email = email;
            this.Course = course;
            this.Phone = phone;
            this.SSN = ssn;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }


        public override bool Equals(object stud)
        {
            var valoare = stud as Student;

            if (stud == null)
            {

                return false;
            }
            return this.First == valoare.First &&
                    this.LastName == valoare.LastName &&
                    this.Middle == valoare.Middle &&
                    this.Address == valoare.Address &&
                    this.Email == valoare.Email &&
                    this.Course == valoare.Course &&   
                    this.Phone == valoare.Phone &&
                    this.SSN == valoare.SSN &&
                    this.Faculty == valoare.Faculty &&             
                    this.University == valoare.University &&
                    this.Specialty == valoare.Specialty;
        }

        public static bool operator ==(Student stud1, Student stud2)
        {
            return Student.Equals(stud1, stud2);
        }

        public static bool operator !=(Student stud1, Student stud2)
        {
            return !(Student.Equals(stud1, stud2));
        }

        public override string ToString()
        {
            return $"{this.Names} ,{this.SSN},{this.Email}, {this.Phone}, {this.Specialty},{this.Faculty},{this.University}";

        }

        public override int GetHashCode()
        {
            return Names.GetHashCode() ^ SSN.GetHashCode() ^ Email.GetHashCode() ^ Phone.GetHashCode() ^ Specialty.GetHashCode() ^ Faculty.GetHashCode() ^ University.GetHashCode();
        }

        object ICloneable.Clone()
        {
            return this.Clone();
        }

        public Student Clone()
        {
            Student result = new Student(this.Names, this.SSN, this.Address, this.Phone, this.Email, this.Course, this.University, this.Faculty, this.Specialty);

            return result;
        }


        public int CompareTo(Student studcurrent)
        {
            int firstNameCompare = this.First.CompareTo(studcurrent.First);

            if (firstNameCompare != 0)
            {
                return firstNameCompare;
            }
            else
            {
                int middleNameCompare = this.Middle.CompareTo(studcurrent.Middle);

                if (middleNameCompare != 0)
                {
                    return middleNameCompare;
                }
                else
                {
                    int lastNameCompare = this.LastName.CompareTo(studcurrent.LastName);

                    if (lastNameCompare != 0)
                    {
                        return lastNameCompare;
                    }
                    else
                    {
                        int SSNCompare = this.SSN.CompareTo(studcurrent.SSN);

                        if (SSNCompare != 0) // If names are equals, compare students by SSN
                        {
                            return SSNCompare;
                        }
                        else // Both students are equals
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}


//first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
