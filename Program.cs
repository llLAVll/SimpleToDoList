
Console.WriteLine("Привет вот мой консольный вариант ToDo листа выбери задачу:");
int mesTsk = 0;

Console.WriteLine(
    "1 Получить список задач;\n" +
    "2 Создать новую задачу\n" +
    "3 Удалить существующую задачу\n" +
    "4 Обновить существующую задачу\n" +
    "5 Выход");
List<string> list = new List<string>();
ToDo toDo = new ToDo();
list = toDo.TaskToDo;

do
{
    string mes = Console.ReadLine();
    switch (mes)
    {
        case "1":
            mesTsk = 1;
            for (int i = 0; i < list.; i++)
            {
                Cosole
            }    

            break;
        case "2":
            mesTsk = 2;
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