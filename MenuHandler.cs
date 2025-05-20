using toDoCLI.Tasks;

namespace toDoCLI.MenuHandler {
    internal class MenuHandler {
        public static void clearDisplay() {
            System.Console.Clear();
        }

        public static void printMenu() {
            Console.WriteLine("[1] Display all tasks");
            Console.WriteLine("[2] Add new task");
            Console.WriteLine("[3] Mark as done");
            Console.WriteLine("[4] Delete task");
            Console.WriteLine("[5] Exit");
            Console.Write("Enter: ");
        }

        public static int selectedOption() {
            while (true) {
                try {
                    int option = Convert.ToInt32(Console.ReadLine());

                    if (option < 1 || option > 5) {
                        Console.Write("Select correct option: ");
                    } else {
                        return option;
                    }
                } catch (FormatException) {
                    Console.Write("Select correct option: ");
                }
            }
        }

        public static void displayTasks(List<ToDoTask> tasks) {
            clearDisplay();

            if (tasks.Count == 0) {
                Console.WriteLine("There is no tasks to display");
                return;
            }

            foreach (ToDoTask task in tasks) {
                Console.WriteLine($"Id: {task.id}");
                Console.WriteLine($"Title: {task.title}");
                Console.WriteLine($"Description: {task.description}");
                Console.WriteLine($"Is Done: {task.isDone}");
                Console.WriteLine($"Done at: {task.dateDone}");
                Console.WriteLine("");
            }
        }

        public static ToDoTask? addTask(int id) {
            while (true) {
                string? title;
                string? description;
                string? ok;

                clearDisplay();

                Console.Write("Enter title: ");
                while (true) {
                    title = Console.ReadLine();
                    if (title == "" || title == null) {
                        Console.Write("Title cannot be empty: ");
                        continue;
                    }
                    break;
                }

                Console.Write("Enter description: ");
                while (true) {
                    description = Console.ReadLine();
                    if (description == "" || description == null) {
                        Console.Write("Description cannot be empty: ");
                        continue;
                    }
                    break;
                }

                while (true) {
                    clearDisplay();

                    Console.WriteLine($"Title: {title}");
                    Console.WriteLine($"Description: {description}");
                    Console.Write("Is it correct? (yes/no): ");

                    ok = Console.ReadLine();

                    if (ok == "" || ok == null) {
                        continue;
                    } else if (ok.ToLower() == "yes") {
                        ToDoTask task = new ToDoTask(id + 1, title, description);
                        return task;
                    } else if (ok.ToLower() == "no") {
                        return null;
                    }
                }
            }
        }

        public static int markAsDone(List<ToDoTask> tasks) {
            int len = tasks.Count;
            int id;

            displayTasks(tasks);

            Console.Write("Select task id to be marked as done: ");
            while (true) {
                try {
                    id = Convert.ToInt32(Console.ReadLine());
                } catch (FormatException) {
                    Console.Write("Select task id to be marked as done: ");
                    continue;
                }

                if (id > len || id < 0) {
                    Console.Write("Index out of range. Select task id to be marked as done: ");
                    continue;
                }

                if (id == 0) {
                    return 0;
                }

                return id;
            }
        }

        public static int toDelete(List<ToDoTask> tasks) {
            int len = tasks.Count;
            int id;

            displayTasks(tasks);

            Console.Write("Select task id to be deleted: ");
            while (true) {
                try {
                    id = Convert.ToInt32(Console.ReadLine());
                } catch (FormatException) {
                    Console.Write("Select task id to be deleted: ");
                    continue;
                }

                if (id > len || id < 0) {
                    Console.Write("Index out of range. Select task id to be deleted: ");
                    continue;
                }

                if (id == 0) {
                    return 0;
                }

                return id;
            }
        }
    }
}
