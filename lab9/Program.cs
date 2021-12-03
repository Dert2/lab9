using System;

namespace lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            Checkpoint checkpoint = new Checkpoint();
            Human student = new Student() { IsHaveQR = true, IsHaveMask = false, Name = "валваллва" };
            Human teacher = new Teacher() { IsHaveQR = true, IsHaveMask = true, Name = "вьдаьвдаь" };
            Human enrolle = new Enrolle() { IsHaveQR = true, Name = "вдадвад" };
            Dog dog = new Dog() { IsHaveMask = true, Name = "бобик" };
            Dove dove = new Dove();
            Squirrel squirrel = new Squirrel();
            checkpoint.VisitorsWantToISIT.Add(student);
            checkpoint.VisitorsWantToISIT.Add(teacher);
            checkpoint.VisitorsWantToISIT.Add(enrolle);
            checkpoint.VisitorsWantToISIT.Add(dog);
            checkpoint.VisitorsWantToISIT.Add(dove);
            checkpoint.VisitorsWantToISIT.Add(squirrel);

            checkpoint.Check();

            Console.WriteLine("Те, кто хочет пройти");
            foreach (IVisitor visitor in checkpoint.VisitorsWantToISIT)
                Console.WriteLine(((IVisitor)visitor).Name);

            Console.WriteLine("Те, кто может пройти");
            foreach (IVisitor visitor in checkpoint.VisitorsCanToISIT)
                Console.WriteLine(((IVisitor)visitor).Name);

        }
    }
}
