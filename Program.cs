using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_BubbleSort
{

    class Program

    {

        static void Main(string[] args)

        {

            runApp();

        }



        public static void runApp()

        {

            string[] students = new string[10];

            students[0] = "Koko";

            students[1] = "Sam";

            students[2] = "Arundati";

            students[3] = "Sangeeta";

            students[4] = "Sindhu";

            students[5] = "Faisal";

            students[6] = " Aashika";

            students[7] = "Carry";

            students[8] = "Chandu";

            students[9] = "Abhishek";



            bool flag = true;

            string temp;

            int numLength = students.Length;

            for (int i = 1; (i <= (numLength - 1)) && flag; i++)

            {

                flag = false;

                for (int j = 0; j < (numLength - 1); j++)

                {

                    if (students[j + 1].CompareTo(students[j]) < 0)

                    {

                        temp = students[j];

                        students[j] = students[j + 1];

                        students[j + 1] = temp;

                        flag = true;

                    }

                }

            }





            foreach (string s in students)

            {

                Console.WriteLine(s);
                Console.ReadLine();

            }

        }

    }

} 

