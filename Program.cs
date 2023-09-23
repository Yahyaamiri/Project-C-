using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create a TODO list in a file on a given path then add a task, remove a task from list//
            string fileName = "C:\\Users\\yahya\\Desktop\\NZSE IT Technical support materials\\Programing project for progaming\\Praticedirectory\\Newfile.txt";

            while (true)
            {
                Console.WriteLine("\nTo-Do List Menu:");
                Console.WriteLine("1. View Tasks");
                Console.WriteLine("2. Add Task");
                Console.WriteLine("3. Clear Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ViewTasks(fileName);
                        break;
                    case "2":
                        AddTask(fileName);
                        break;
                    case "3":
                        ClearTasks(fileName);
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        static void ViewTasks(string fileName)
        {
            if (File.Exists(fileName))
            {
                Console.WriteLine("\n--- To-Do List ---");
                List<string> tasks = File.ReadAllLines(fileName).ToList();

                if (tasks.Count > 0)
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                }
                else
                {
                    Console.WriteLine("No tasks found.");
                }
            }
            else
            {
                Console.WriteLine("No to-do list found.");
            }
        }

        static void AddTask(string fileName)
        {
            Console.Write("\nEnter a task: ");
            string task = Console.ReadLine();

            if (!string.IsNullOrEmpty(task))
            {
                File.AppendAllText(fileName, task + Environment.NewLine);
                Console.WriteLine("Task added successfully.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty. Please try again.");
            }
        }

        static void ClearTasks(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
                Console.WriteLine("\nAll tasks cleared.");
            }
            else
            {
                Console.WriteLine("No to-do list found to clear.");
            }
        }
    }
}













// *************************************Project************************************************//

/*

// project that demonstrates file handling and exception handling. In this project,
// we'll create a simple console application that allows the user to read and write text to a file.
// We'll handle exceptions related to file operations and input validation.
while (true)
{
    Console.WriteLine("1. Read from file");
    Console.WriteLine("2. Write to file");
    Console.WriteLine("3. Quit");
    Console.Write("Select an option (1/2/3): ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Enter the file path to read from: ");
            string readFilePath = Console.ReadLine();
            ReadFromFile(readFilePath);
            break;
        case "2":
            Console.Write("Enter the file path to write to: ");
            string writeFilePath = Console.ReadLine();
            WriteToFile(writeFilePath);
            break;
        case "3":
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
            break;
    }
}
}



static void ReadFromFile(string filePath)
{
try
{
    string content = File.ReadAllText(filePath);
    Console.WriteLine("\nFile Contents:\n" + content);
}
catch (FileNotFoundException ex)
{
    Console.WriteLine("File not found: " + ex.Message);
}
catch (IOException ex)
{
    Console.WriteLine("Input/Output error: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
}

static void WriteToFile(string filePath)
{
Console.Write("Enter the text to write to the file: ");
string text = Console.ReadLine();

try
{
    File.WriteAllText(filePath, text);
    Console.WriteLine("\nText written to the file successfully.");
}
catch (IOException ex)
{
    Console.WriteLine("Input/Output error: " + ex.Message);
}
catch (UnauthorizedAccessException ex)
{
    Console.WriteLine("Access to the file is unauthorized: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}
}
}
}

*/
