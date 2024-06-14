namespace Homework_10._06._2024_OverloadingOperations
{
   
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new();
            student.AddTestsRatings(10);
            student.AddCourseWorksRatings(12);
            student.AddExamsRatings(12);

            Student student1 = new("Evgeniya", "Sadova");
            student1.AddTestsRatings(12);
            student1.AddCourseWorksRatings(12);
            student1.AddExamsRatings(12);

            Student student2 = new("Irina", "Strat");
            student2.AddTestsRatings(12);
            student2.AddCourseWorksRatings(12);
            student2.AddExamsRatings(12);

            Student student3 = new("Liliya", "Khachatryan");
            student3.AddTestsRatings(12);
            student3.AddCourseWorksRatings(12);
            student3.AddExamsRatings(12);

            Student student4 = new("Artem", "Karp");
            student4.AddTestsRatings(12);
            student4.AddCourseWorksRatings(12);
            student4.AddExamsRatings(12);

            Student student5 = new("Aleksandr", "Martinov");
            student5.AddTestsRatings(12);
            student5.AddCourseWorksRatings(12);
            student5.AddExamsRatings(12);

            Student student6 = new("Vitaly", "Ogorodnikov");
            student6.AddTestsRatings(2);
            student6.AddCourseWorksRatings(2);
            student6.AddExamsRatings(2);

            Student student7 = new("Maxim", "Fedorov-Marushchak");
            student7.AddTestsRatings(12);
            student7.AddCourseWorksRatings(12);
            student7.AddExamsRatings(12);

            Student student8 = new("Petr", "Petrenko");
            student8.AddTestsRatings(9);
            student8.AddCourseWorksRatings(8);
            student8.AddExamsRatings(7);

            Group group = new();

            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            group.AddStudent(student4);
            group.AddStudent(student5);
            group.AddStudent(student6);
            group.AddStudent(student7);
            group.AddStudent(student8);
            group.AddStudent(student);

            group.Print();
            Console.WriteLine();

            group.RemoveMostUnderachieverStudent();

            group.Print();
            Console.WriteLine();

            Group group1 = new("PV415", "CyberSecurity");
            group.StudentTransfer(student, group1);

            group.Print();
            Console.WriteLine();

            group1.Print();
            Console.WriteLine();

            group1.EditingGroupData("ПВ415", "Кiбербезпека", 1);
            group1.Print();
            Console.WriteLine();

            //////////////////////////            OVERLOAD            //////////////////////////////////////////////
            
            if(student > student8)
            {
                Console.WriteLine("Student " + student.GetName() + " " + student.GetLastName() + " studies better.");
            }
            else if(student < student8)
            {
                Console.WriteLine("Student " + student8.GetName() + " " + student8.GetLastName() + " studies better.");
            }
            Console.WriteLine();

            foreach (var stud in group.students)
            {
                if (stud)
                {
                    Console.WriteLine(stud.GetName() + " " + stud.GetLastName() + " excellent student.");
                }
                else
                {
                    Console.WriteLine(stud.GetName() + " " + stud.GetLastName() + " not an excellent student.");
                }
            }
            Console.WriteLine();

            if (student == student8)
            {
                Console.WriteLine("Student " + student.GetName() + " " + student.GetLastName() + " and " +
                    "student " + student8.GetName() + " " + student8.GetLastName() + " equal");
            }
            else if (student != student8)
            {
                Console.WriteLine("Student " + student.GetName() + " " + student.GetLastName() + " and " +
                    "student " + student8.GetName() + " " + student8.GetLastName() + " not equal");
            }
            Console.WriteLine();

            Console.WriteLine(group[5].GetName() + " " + group[5].GetLastName());
            Console.WriteLine();

            if (group == group1)
            {
                Console.WriteLine("Group" + " " + group.GetNameOfGroup() + "(" + group.students.Count + " students) " + " and group " + 
                    group1.GetNameOfGroup() + " (" + group1.students.Count + " students)" + " equals.");
            }
            else if(group != group1)
            {
                Console.WriteLine("Group" + " " + group.GetNameOfGroup() + " (" + group.students.Count + " students)" + " and group " +
                    group1.GetNameOfGroup() + " (" + group1.students.Count + " students)" + " not equals.");
            }
        }
    }
}
