using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DotNetPerf
{
    internal class Examples
    {
        public void InEfficientQuery()
        {
            var ids = new List<int>();
            foreach (var id in ids)
            {
                // var user = db.Users.FirstOrDefault(u => u.Id == id); // N queries!
            }
        }
        public void EfficientQuery() 
        {
            // var users = db.Users.Where(u => ids.Contains(u.Id)).ToList(); // 1 query
        }




        public void TooManyThreads()
        {
            for (int i = 0; i < 1000; i++)
            {
                new Thread(() => DoWork()).Start(); // overhead from thread creation
            }
        }
        public void UseThreadPool()
        {
            for (int i = 0; i < 1000; i++)
            {
                Task.Run(() => DoWork()); // uses thread pool
            }
        }
        private void DoWork()
        { }


        // Bad
        public void LargeSerialization()
        {
            var json = File.ReadAllText("large.json");
            var obj = JsonSerializer.Deserialize<MyBigObject>(json);
        }
        // Good
        public async Task StreamBasedSerialization()
        {
            using var stream = File.OpenRead("large.json");
            var obj = await JsonSerializer.DeserializeAsync<MyBigObject>(stream);
        }
    }

    public class MyBigObject { }
}
