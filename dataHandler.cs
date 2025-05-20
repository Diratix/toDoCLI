using toDoCLI.Tasks;

namespace toDoCLI.DataHandler {
    internal class DataHandler {
        public static void saveData(List<ToDoTask> tasks) {
            try {
                using (StreamWriter writer = new StreamWriter("./tasks.tdl")) {
                    foreach (ToDoTask task in tasks) {
                        writer.WriteLine($"{task.id};{task.title};{task.description};{task.isDone};{task.dateDone}");
                    }
                }
            } catch (FileNotFoundException) {
                Console.WriteLine("Save file doesn't exist");
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
        }

        public static List<ToDoTask> readData() {
            try {
                using (StreamReader reader = new StreamReader("./tasks.tdl")) {
                    string[] dataArr = new string[5];
                    List<ToDoTask> tasks = new List<ToDoTask>();

                    while (!reader.EndOfStream) {
                        string? line = reader.ReadLine();
                        if (line == null) continue;
                        line = line.Trim();
                        dataArr = line.Split(';');

                        ToDoTask task = new ToDoTask(Convert.ToInt32(dataArr[0]), dataArr[1], dataArr[2]);
                        task.isDone = Convert.ToBoolean(dataArr[3]);
                        task.dateDone = dataArr[4];
                        
                        tasks.Add(task);
                    }

                    return tasks;
                }
            } catch (FileNotFoundException) {
                Console.WriteLine("Save file doesn't exist");
                return new List<ToDoTask>();
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                return new List<ToDoTask>();
            }
        }
    }
}
