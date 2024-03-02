namespace SimpleToDoList
{

    class Program
    {

        public static void Main(string[] args)
        {
            
            Console.WriteLine("Привет вот мой консольный вариант ToDo листа выбери задачу:");
            int mesTsk = 0;

            Console.WriteLine(
                "1 Получить список задач;\n" +
                "2 Создать новую задачу\n" +
                "3 Удалить существующую задачу\n" +
                "4 Обновить существующую задачу\n" +
                "5 Выход  ");
                
            List<string> list = new List<string>();
            ToDo toDo = new ToDo();

            int id = -1;
            string title = "";
            string description = "";
            DateTime dueDate;
            bool isCopleted =false;


            string id_str = "";


            do
            {
                string mes = Console.ReadLine();
                switch (mes)
                {
                    case "1":
                        mesTsk = 1;
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("");
                        }

                        break;
                    case "2":
                        mesTsk = 2;
                        
                        Random r =   new Random();
                        id = r.Next() + r.Next() / r.Next();
                        id_str = id.ToString();
                        Console.WriteLine("Создание новой задачи: \n Заголовок:");
                        title = Console.ReadLine();

                        Console.WriteLine("Описание:");
                        description = Console.ReadLine();

                        Console.WriteLine("Дата воддить в формате ( 01.01.2000 ):");
                        dueDate = Convert.ToDateTime(Console.ReadLine());

                        Console.WriteLine("Выполнена или нет (Y или N):");
                        string text = Console.ReadLine();
                        int n = 0;
                        do
                            if (text == "y" || text == "Y" || text == "у" || text == "У")
                            {
                                n = 1;
                                isCopleted = true;
                                text = "";
                            }
                            else if (text == "n" || text == "N" || text == "Н" || text == "Н")
                            {
                                n = 2;
                                isCopleted = false;
                                text = "";
                            }
                        while (n == 1 || n == 2 );


                        //toDo.AddToDo(id);
                        break;
                    case "3":
                        mesTsk = 3;
                        break;
                    case "4":
                        mesTsk = 4;
                        break;
                    case "5":
                        mesTsk = 5;
                        Console.WriteLine("До скорой встречи");
                        Environment.Exit(0); // Закрыть консоль
                        break;
                    default:
                        Console.WriteLine("Такой команды нет :(");
                        mesTsk = -1;
                        break;
                }
            } while (mesTsk == -1);

            if (mesTsk != -1)
            {
                Console.ReadLine();
            }

        }
    }

    class ToDo
    {
        //
        public List<object> TaskToDo = new List<object>();

        int id;
        string title;
        string description;
        DateTime dueDate;
        bool isCopleted;

        public void ToDoList(int Id, string Title, string Description, DateTime DueDate, bool IsCopleted, List<object> TaskToDo)
        {
            this.id = Id;
            this.title = Title;
            this.description = Description;
            this.dueDate = DueDate;
            this.isCopleted = IsCopleted;

            //Надо ли?
            this.TaskToDo = TaskToDo;
        }

        public void AddToDo(List<object> TaskToDo)
        {

            this.TaskToDo.Add(TaskToDo);

        }
        public void IdRemoveToDo(List<string> ListToDo, int Id)
        {

            if (this.id == Id)
            {
                this.TaskToDo.Remove(this.id);
            }

        }
        public void UpdateToDo(List<string> ListToDo)
        {

        }

        public void SearchToDo(List<string> ListToDo, string Title)
        {

            if (this.title == Title)
            {
                Console.WriteLine($"По запросу найден:\n {ListToDo[this.id]} ");
            }

        }

        public void IdSearchToDo(List<string> ListToDo, int Id)
        {

            if (this.id == Id)
            {
                Console.WriteLine($"По запросу найден:\n {ListToDo[this.id]} ");

            }
        }
    }
}