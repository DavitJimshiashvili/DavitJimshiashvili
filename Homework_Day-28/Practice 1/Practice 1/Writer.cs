using System;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace Practice_1
{
    static class Writer
    {
        public async static Task Write(string fileName, CancellationToken token, int delayAmount)
        {
            string path = $@"../../../{fileName}";

            using (FileStream fs = File.Open(path, FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    while (!token.IsCancellationRequested)
                    {
                        try
                        {
                            await sw.WriteLineAsync(fileName);
                            await Task.Delay(delayAmount);
                            token.ThrowIfCancellationRequested();
                        }
                        catch (OperationCanceledException)
                        {
                        }
                    }
                }
            }
        }
    }
}
