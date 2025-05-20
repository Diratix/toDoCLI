namespace toDoCLI.Tasks {
    public class TaskAlreadyDoneException : Exception {
        public TaskAlreadyDoneException(string message) : base(message) { }
    }

    public class ToDoTask {
        public int id {  get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public bool isDone { get; set; }
        public string dateDone { get; set; }

        public ToDoTask(int id, string title, string description) {
            this.id = id;
            this.title = title;
            this.description = description;
            this.isDone = false;
            this.dateDone = "Not Done Yet";
        }

        public void setDone() {
            if (!isDone) {
                this.dateDone = DateTime.Now.ToString();
                this.isDone = true;
            } else {
                throw new TaskAlreadyDoneException($"Task {this.id} is arleady finished!");
            }
        }
    }
}
