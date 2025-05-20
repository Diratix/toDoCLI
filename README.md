# 📝 toDoCLI

A simple CLI-based To-Do list manager written in C#.

## 📦 Features

This application currently allows you to:

- View all tasks
- Add new tasks
- Mark tasks as done ✅
- Delete tasks 🗑️
- Exit the program gracefully

> **Note:** When using the "mark as done" or "delete" options, entering `0` cancels the operation.

---

## 🚧 Planned Features

Future updates will include:

- ✅ Saving and loading tasks from a `tasks.json` file
- 🔄 Persistent data between sessions
- 📁 Better file handling and error recovery
- 📄 Improved task formatting
- 🧪 Unit tests for task operations

---

## 🚀 How to Use

1. **Build and run** the application in Visual Studio or via CLI.
2. You will be presented with a simple menu:

```
[1] Display all tasks
[2] Add new task
[3] Mark as done
[4] Delete task
[5] Exit
```

3. Enter the number corresponding to the action you'd like to perform.
4. For adding a task, you'll be prompted to enter a title and description.
5. When marking or deleting tasks, enter the task `id`. To cancel the operation, enter `0`.

---

## 📌 Example

```text
Enter: 2
Enter title: Learn C#
Enter description: Finish the toDoCLI project

Is it correct? (yes/no): yes
Successfully added task named Learn C#

Press any key to continue...
```

---

## 🛠 Technologies

- Language: **C#**
- Platform: **.NET Core**
- Interface: **Console**

---

## 📁 File Structure

```
/toDoCLI
│
├── Program.cs              # Main app loop and logic
├── MenuHandler.cs          # Handles user input and menu logic
└── Tasks/
    ├── ToDoTask.cs         # Task model
    └── TaskAlreadyDoneException.cs  # Custom exception
```

---

## ⚠️ Notes

- On first run, a `tasks.json` file is created automatically (saving/loading not yet implemented).
- This is a learning project and may not cover all edge cases.

---

## 📄 License

This project is open source and free to use.

