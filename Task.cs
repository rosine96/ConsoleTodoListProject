using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TodoList
{
    public class Task
    {
        public string? name { get; set; }
        public bool done { get; set; } = false;
        public string startTime { get; set; }
        public string endTime { get; set; }
        public Task(string name,string startTime,string endTime)
        {
            this.name = name;
            this.startTime = startTime;
            this.endTime = endTime;
        }
        public void AddTask(string filepath) 
        {
            File.AppendAllText(filepath, $"{this.name}:           {this.startTime}-{this.endTime}"+Environment.NewLine);
        }
        public static void GetMyTask(string filepath)
        {
            try
            {
                string[] allTask = File.ReadAllLines(filepath);
                for (int i = 0; i < allTask.Length; i++)
                {
                    Console.WriteLine($"{i + 1}-{allTask[i]}");
                }
            }
            catch (Exception e) { Console.WriteLine(e.Message); }


        }
        public static void DeleteTask(int number, string filepath)
        {
            string[] allTask = File.ReadAllLines(filepath);
            string[] newLines = new string[allTask.Length-1];
           int j = 0;
            for (int i = 0; i < allTask.Length; i++)
            {
                if(i !=number-1)
                {
                    newLines[j] = allTask[i];
                    j++;
                }
                
            }
            File.Delete(filepath);
            File.AppendAllLines(filepath, newLines);
            Console.WriteLine($"Success deleted task");
        }
        public static void  FinishTask(int number, string filepath)
        {
            string[] allTask = File.ReadAllLines(filepath);
            string[] newLines = new String[allTask.Length];
            for (int i = 0; i < allTask.Length; i++)
            {
                if (i != number - 1)
                {
                    newLines[i] = allTask[i];
                    
                }
                else
                {
                    newLines[i] = allTask[i]+"------finish---";
                    
                }

            }
            File.Delete(filepath);
            File.AppendAllLines(filepath, newLines);
        }
       

    }
   
}
