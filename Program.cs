using System;
using System.Collections.Generic;

Console.WriteLine("Welcome to Todo List App!");

// ✅ Declare todoList at top so all methods can access its
List<string> todoList = new List<string>();

// Main menu loop
while (true)
{
    Console.WriteLine("\n--- Todo List Menu ---");
    Console.WriteLine("[S]ee Todo List");
    Console.WriteLine("[A]dd Todo Item");
    Console.WriteLine("[R]emove Todo Item");
    Console.WriteLine("[E]xit");
    Console.Write("Enter your choice: ");

    var userChoice = Console.ReadLine()?.ToUpper();

    switch (userChoice)
    {
        case "S":
            ShowTodoList();
            break;

        case "A":
            AddDescription();
            break;

        case "R":
            RemoveDescription();
            break;

        case "E":
            Console.WriteLine("Exiting program...");
            return; // exit program safely

        default:
            Console.WriteLine("Invalid input, please try again.");
            break;
    }
}

// ================= Methods =================

// Show all todo items
void ShowTodoList()
{
    Console.WriteLine("\n--- Todo List ---");
    if (todoList.Count == 0)
    {
        Console.WriteLine("Your todo list is empty.");
        return;
    }
    int i = 1;
    foreach (var item in todoList)
    {
        Console.WriteLine($"{i}. {item}");
        i++;
    }
}

// Add a todo item
void AddDescription()
{
    while (true)
    {
        Console.Write("\nEnter description of todo item: ");
        var description = Console.ReadLine();

        if (string.IsNullOrEmpty(description))
        {
            Console.WriteLine("Description cannot be empty. Please try again.");
            continue;
        }
        if (todoList.Contains(description))
        {
            Console.WriteLine("Description already exists. Please enter a new one.");
            continue;
        }

        todoList.Add(description);
        Console.WriteLine($"Added todo item: {description}");
        break;
    }
}

// Remove a todo item
void RemoveDescription()
{
    while (true)
    {
        Console.Write("\nEnter description of todo item to remove: ");
        var description = Console.ReadLine();

        if (string.IsNullOrEmpty(description))
        {
            Console.WriteLine("Description cannot be empty. Please try again.");
            continue;
        }

        if (todoList.Remove(description))
        {
            Console.WriteLine($"Removed todo item: {description}");
            break;
        }
        else
        {
            Console.WriteLine("Description not found. Please try again.");
        }
    }
}
