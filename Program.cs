Console.WriteLine("Привет вот мой консольный вариант ToDo листа выбери задачу:");
int mesTsk = 0;

    Console.WriteLine("1 Получить список задач;\n" +
        "2 Создать новую задачу\n" +
        "3 Удалить существующую задачу\n" +
        "4 Обновить существующую задачу\n" +
        "5 Выход");
do {
    string mes = Console.ReadLine();
    switch (mes)
    {
        case "1":
            mesTsk = 1;
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
            Console.Clear() ; // Закрыть консоль
            break;
        default:
            Console.WriteLine("Такой команды нет :(");
            mesTsk = -1;
            break;
    }
} while (mesTsk == -1);



Console.ReadLine();