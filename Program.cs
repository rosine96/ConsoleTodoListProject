using System.IO;
namespace TodoList
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            int operation;
            int choix;
            do
            {
                Console.WriteLine(@"Welcome to ToDoList!
                                   what do you want?:
                                   1-Add a task
                                   2-Get your ToDoList
                                   3-Delete a task
                                   4-mark task as finish
                                   5-quitter
                                   ");
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("entrer votre tache!");
                        string tache = Console.ReadLine();
                        Console.WriteLine("entrer l'heure prevu pour le debut de la tache!(format heure:min exemple 12:30)");
                        string debut = Console.ReadLine();
                        Console.WriteLine("entrer l'heure prevu pour la fin de la tache!(format heure:min exemple 12:30)");
                        string fin = Console.ReadLine();
                        Task myTask = new Task(tache, debut, fin);
                        myTask.AddTask("task.txt");
                        break;
                    case 2:

                        Task.GetMyTask("task.txt");

                        break;
                    case 3:
                        Task.GetMyTask("task.txt");
                        Console.WriteLine(@"--------Quelle tache voulez vous supprimer?--------(entrer le numero de la tache)");
                        int numero = int.Parse(Console.ReadLine());
                        Task.DeleteTask(numero, "task.txt");
                        break;
                    case 4:
                        Task.GetMyTask("task.txt");
                        Console.WriteLine(@"--------Quelle tache avez vous termine?--------(entrer le numero de la tache)");
                        numero = int.Parse(Console.ReadLine());
                        Task.FinishTask(numero, "task.txt");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("veuillez choisir un numero parmis ceux de la liste\n");
                        break;
                }
                Console.WriteLine(@"Avez vous une autre operation a effectuer?
                                               1-oui
                                               2-non");
                 choix = int.Parse(Console.ReadLine());
            } while (choix == 1);
        }
    }
}