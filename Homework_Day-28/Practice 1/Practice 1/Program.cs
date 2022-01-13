using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Task> tasksList = new List<Task>();
            var cancellationTokenSource = new CancellationTokenSource();

            for (int i = 1; i < 11; i++)
            {

                string path = $"Task{i}.txt";
                int delayTime = i * 100;
                Task T = Writer.Write(path, cancellationTokenSource.Token, delayTime);
                tasksList.Add(T);
            }

            foreach (var task in tasksList)
            {
                Task.Run(() => task);
            }

            Task cancellationTask = new Task(() =>
            {
                Console.WriteLine("Enter token \"x\" to cancel the  tasks");
                char input = char.Parse(Console.ReadLine());
                if (input == 'x' || input == 'X')
                {
                    cancellationTokenSource.Cancel();
                }
            }
            );
            cancellationTask.RunSynchronously();
            Task.WaitAll(tasksList.ToArray());

        }
    }
}
