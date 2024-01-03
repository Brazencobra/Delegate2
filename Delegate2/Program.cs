using Delegate2.Models;

namespace Delegate2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Exam class

             - Student
             - Point
             - Subject
             - StartDate
             - EndDate


            Exams siyahisi duzeldirsiniz
            console-dan deyerler goturerek examleri elave edirsiniz
            Butun examleri daxil etdikden sonra console-da asagidaki siyahilari gosterirsiniz:
            - pointi 50-den cox olan  examlarin siyahisini gosterirsiniz
            - son 1 hefte erzinde olan  examlarin siyahisini gosterirsiniz
            - 1-saatdan uzun ceken imtahanlarin siyahisi


            Siyahilari gosterende asagidaki datalari gosterirsiniz her bir siyahi ucun
             - StudentName  Subject  Point  Duration
            */

            Student student1 = new Student("Elxan");
            Student student2 = new Student("Vusal");
            Student student3 = new Student("Nihad");
            DateTime start1 = new DateTime(2024, 1, 2, 4, 0, 0);
            DateTime end1 = new DateTime(2024, 1, 2, 6, 0, 0);
            DateTime start2 = new DateTime(2022, 12, 4, 6, 0, 0);
            DateTime end2 = new DateTime(2022, 12, 5, 6, 0, 0);
            DateTime start3 = new DateTime(2022, 11, 29, 6, 0, 0);
            DateTime end3 = new DateTime(2022, 12, 5, 6, 0, 0);
            List<Exam> examlist = new List<Exam>();
            Exam exam1 = new Exam(student1, 80, "Math", start1, end1);
            Exam exam2 = new Exam(student2, 30, "Physich", start2, end2);
            Exam exam3 = new Exam(student3, 70, "Biology", start3, end3);
            examlist.AddRange(new Exam[] {exam1,exam2,exam3});

            examlist.FindAll(x=>x.Point >= 50).ForEach(x => 
            {
                Console.WriteLine(x.Student.Name + " " + x.Subject + " " + x.Point + " " + x.EndDate.Subtract(x.StartDate));
            });
            Console.WriteLine(" - - - - - - - - - - - -");
            examlist.FindAll(x=> DateTime.Now.Subtract(x.StartDate) <= TimeSpan.FromDays(7)).ForEach(x => 
            {
                Console.WriteLine(x.Student.Name + " " + x.Subject + " " + x.Point + " " + x.EndDate.Subtract(x.StartDate));
            });
            Console.WriteLine(" - - - - - - - - - - - -");
            examlist.FindAll(x => x.EndDate.Subtract(x.StartDate) >= TimeSpan.FromHours(1)).ForEach(x => 
            {
                Console.WriteLine(x.Student.Name + " " + x.Subject + " " + x.Point + " " + x.EndDate.Subtract(x.StartDate));
            });
        }
    }
}