using System;

namespace StructName
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Name myFullName = new Name("Yunus", "Emre", "Karadag");
            string myName = myFullName.ToString(), inits = myFullName.Initials();
            Console.WriteLine("My name is {0}.", myName);
            Console.WriteLine($"My initials are {inits}");
            Console.ReadLine();

        }
        public struct Name
        {
            private string fname, mname, lname;
            public Name(string first, string middle, string last)
            {
                fname = first;
                mname = middle;
                lname = last;
            }
            public string firstName
            {
                get { return fname; }
                set { fname = firstName; }
            }
            public string middleName
            {
                get { return mname; }
                set { mname = middleName; }
            }
            public string lastName
            {
                get { return lname; }
                set { lname = lastName; }
            }
            public override string ToString()
            {
                return string.Format($"{firstName} {middleName}");
            }
            public string Initials()
            {
                return string.Format($"{firstName.Substring(0, 1)}{middleName.Substring(0, 1)}{lastName.Substring(0, 1)}");
            }
        }
    }
}
