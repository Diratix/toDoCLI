using toDoCLI.Tasks;
using toDoCLI.MenuHandler;

List<ToDoTask> tasks = new List<ToDoTask>();

if (!File.Exists("tasks.json")) {
    File.Create("tasks.json");
}

while (true) {
    Console.Clear();
    MenuHandler.printMenu();

    int option = MenuHandler.selectedOption();

    switch (option) {
        case 1:
            MenuHandler.displayTasks(tasks);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            break;
        case 2:
            ToDoTask? task = MenuHandler.addTask(tasks.Count);
            if (task != null) {
                tasks.Add(task);
                Console.WriteLine($"Succesfully added task named {task.title}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                break;
            } else {
                break;
            }
    }
}


