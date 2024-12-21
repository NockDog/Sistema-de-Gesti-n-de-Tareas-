using System;
using System.Collections.Generic;

namespace TaskManagementSystem
{
    // Clase Task
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            IsCompleted = false;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id} | Título: {Title} | Descripción: {Description} | Completada: {(IsCompleted ? "Sí" : "No")}");
        }
    }

    // Clase TaskManager
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private const int MaxTasks = 10;

        public void AddTask(string title, string description)
        {
            if (tasks.Count >= MaxTasks)
            {
                Console.WriteLine("No se pueden agregar más tareas. Límite alcanzado.");
                return;
            }

            int newId = tasks.Count > 0 ? tasks[tasks.Count - 1].Id + 1 : 1;
            Task newTask = new Task(newId, title, description);
            tasks.Add(newTask);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        public void ListAllTasks()
        {
            Console.WriteLine("===== LISTA DE TAREAS =====");
            if (tasks.Count == 0)
            {
                Console.WriteLine("No hay tareas disponibles.");
                return;
            }

            foreach (var task in tasks)
            {
                task.DisplayInfo();
            }
        }

        public void CompleteTask(int id)
        {
            Task task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                task.IsCompleted = true;
                Console.WriteLine("Tarea marcada como completada.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada.");
            }
        }

        public void DeleteTask(int id)
        {
            Task task = tasks.Find(t => t.Id == id);
            if (task != null)
            {
                tasks.Remove(task);
                Console.WriteLine("Tarea eliminada exitosamente.");
            }
            else
            {
                Console.WriteLine("Tarea no encontrada.");
            }
        }
    }

    // Clase Program
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                Console.Clear(); // Limpia la consola antes de mostrar el menú
                Console.WriteLine("===== GESTIÓN DE TAREAS =====");
                Console.WriteLine("1. Agregar nueva tarea");
                Console.WriteLine("2. Listar todas las tareas");
                Console.WriteLine("3. Marcar tarea como completada");
                Console.WriteLine("4. Eliminar tarea");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Ingrese el título de la tarea: ");
                        string title = Console.ReadLine();
                        Console.Write("Ingrese la descripción de la tarea: ");
                        string description = Console.ReadLine();
                        taskManager.AddTask(title, description);
                        break;

                    case "2":
                        Console.Clear(); // Limpia la consola antes de mostrar la lista
                        taskManager.ListAllTasks();
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey(); // Espera entrada del usuario para continuar
                        break;

                    case "3":
                        Console.Clear(); // Limpia la consola y muestra la lista antes de solicitar el ID
                        taskManager.ListAllTasks();
                        Console.Write("\nIngrese el ID de la tarea a completar: ");
                        if (int.TryParse(Console.ReadLine(), out int completeId))
                        {
                            taskManager.CompleteTask(completeId);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey(); // Pausa antes de regresar al menú
                        break;

                    case "4":
                        Console.Clear(); // Limpia la consola y muestra la lista antes de solicitar el ID
                        taskManager.ListAllTasks();
                        Console.Write("\nIngrese el ID de la tarea a eliminar: ");
                        if (int.TryParse(Console.ReadLine(), out int deleteId))
                        {
                            taskManager.DeleteTask(deleteId);
                        }
                        else
                        {
                            Console.WriteLine("ID inválido.");
                        }
                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey(); // Pausa antes de regresar al menú
                        break;

                    case "5":
                        Console.WriteLine("Saliendo del programa...");
                        return;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }
    }
}
