using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace Task_3_Class
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
        l1:
            Console.Write("Telebe sayini daxil edin ");

            if (!int.TryParse(Console.ReadLine(), out int say) || say <= 0)
            {
                Console.WriteLine("0-dan boyuk eded daxil edilmelidir!");
                goto l1;
            }
            Students [] student= new Students[say];

            for (int i = 0; i < student.Length; i++)
            {
                Students telebe = new Students();
                telebe.name = Helper.ReadString($"{i + 1}.Name");
                telebe.surname = Helper.ReadString($"{i + 1}. Surname");
                telebe.age = Helper.ReadInt($" {i + 1}.Age", 18, 90);
                telebe.speciality = Helper.ReadString($"{i + 1}.Speciality");
                telebe.groupNo = Helper.ReadInt($"{i + 1}.GroupNo", 1, 0);

                student[i] = telebe;
            }

            Console.WriteLine("===========================");
            for (int i = 0; i < student.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(student[i]);
            }










        }
    }
}
