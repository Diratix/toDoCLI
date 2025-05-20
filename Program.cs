using toDoCLI.Tasks;
using toDoCLI.MenuHandler;

List<ToDoTask> tasks = new List<ToDoTask>();
bool timeToExit = false;

if (!File.Exists("tasks.json")) {
    File.Create("tasks.json");
}

while (true) {
    if (timeToExit) {
        Console.WriteLine("See you later!");
        break;
    }

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
        case 3:
            int idToDone = MenuHandler.markAsDone(tasks);

            if (idToDone == 0) {
                Console.WriteLine("Operation cancelled");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                break;
            } else {
                tasks[idToDone - 1].isDone = true;
                tasks[idToDone - 1].dateDone = DateTime.Now.ToString();
                Console.WriteLine($"Succesfully marked task of id {idToDone} as done");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                break;
            }
        case 4:
            int idToDelete = MenuHandler.toDelete(tasks);

            if (idToDelete == 0) {
                Console.WriteLine("Operation cancelled");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                break;
            } else {
                tasks.RemoveAt(idToDelete - 1);
                Console.WriteLine($"Succesfully deleted task of id {idToDelete}");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey(true);
                break;
            }
        case 5:
            timeToExit = true;
            break;
    }
}