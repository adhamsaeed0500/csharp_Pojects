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
            // 4- mark task as completed 
            // 5- exist 


            Console.WriteLine("welcome user ");
            Console.WriteLine("enter choice from 1-5");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
            }



        }


        private static void AddTask()
        {
            Console.WriteLine("enter you task ");
            string task = Console.ReadLine();
          
            try
            {
             tasks.AddLast(task);

            }catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine("task Added");


        }
}   }
