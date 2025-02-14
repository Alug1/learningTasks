
public class TodoManager
{
    internal class ToDoList : List<string>
    {
        private List<string> tasks = new List<string>();
        public void ShowTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Список задач пуст.");
            }
            else
            {
                Console.WriteLine("Список задач:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine($"Задача добавлена: {task}");
        }
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                string removedTask = tasks[index];
                tasks.RemoveAt(index);
                Console.WriteLine($"Задача удалена: {removedTask}");
            }
            else
            {
                Console.WriteLine("Неверный индекс задачи.");
            }
        }
    }

    public static void Main(String[] args)
    {
        ToDoList todoList = new ToDoList();
        bool Running = true;
        while (Running)
        {
            Console.WriteLine("\nМенеджер списка дел");
            Console.WriteLine("1. Добавить задачу в список");
            Console.WriteLine("2. Удалить задачу");
            Console.WriteLine("3. Выйти");
            Console.Write("Выберите действие: ");

            string choice = Console.ReadLine();
            todoList.ShowTasks();
            switch (choice)
            {
                case "1":
                    Console.Write("Введите задачу: ");
                    string task = Console.ReadLine();
                    todoList.AddTask(task);

                    break;

                case "2":
                    Console.Write("Введите индекс задачи для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int removeIndex))
                    {
                        todoList.RemoveTask(removeIndex - 1);
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод.");
                    }
                    break;

                case "3":
                    Running = false;
                    break;


            }
        }
    }
}

