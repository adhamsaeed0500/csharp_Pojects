namespace Task_Tracker
{
    internal class Program
    {
       public static LinkedList<string> tasks = new LinkedList<string>();
        static void Main(string[] args)
        {
            // 1- add task 
            // 2- remove task
            // 3- show all tasks 
            // 4- exist 
            Boolean exist = false;
            while (!exist)
            {
                Console.WriteLine("welcome user ");
                Console.WriteLine("enter choice from 1-5");
                Console.WriteLine("1- add task ");
                Console.WriteLine("2- showall task");
                Console.WriteLine("3- Remove task");
                Console.WriteLine("4- exist");


                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ShowAllTasks();
                        break;
                    case "3":
                        RemoveTask();
                        break;
                    case "4":
                        exist = true;
                        break;



                }
            }
        }


        private static void AddTask()
        {
            Boolean add = true;

            while (add)
            {
                try
                {
                    Console.WriteLine("enter you task ");

                    tasks.AddLast(Console.ReadLine());

                    Console.WriteLine("task Added");
                    Console.WriteLine("would you like to add another task Y/N");
                    char input = Convert.ToChar(Console.ReadLine());
                    switch (input)
                    {
                        case 'Y':
                            add = true;
                            break;
                        case 'N':
                            add = false;
                            break;
                        default:
                            add = false;
                            break;
                    }                
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.ToString());
                }
            }




        }
        private static void RemoveTask()
        {
            ShowAllTasks();
            Console.WriteLine("which task whould you like to remove");
            string input = Console.ReadLine();
            tasks.Remove(input);
            Console.WriteLine("task removed");

        }

        private static void ShowAllTasks()
        {
            int number = 1;
            if (tasks.Count < number)
                Console.WriteLine("there are no tasks to show");


            foreach (var item in tasks)
            {
                Console.WriteLine($"{number} - {item}");
                number++;
            }

        }


    }   }
