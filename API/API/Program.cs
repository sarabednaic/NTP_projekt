using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    public static async Task Main(string[] args)
    {
        using (var client = new HttpClient())
        {
            try
            {
                var url = "https://projecthistoryteamplan-default-rtdb.firebaseio.com/taskHistory.json";
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                var responseJson = await response.Content.ReadAsStringAsync();
                var taskHistory = JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(responseJson);

                List<List<string>> taskHistoryList = new List<List<string>>();

                foreach (var task in taskHistory)
                {
                    List<string> taskDetails = new List<string>();

                    taskDetails.Add(task.Value["aktivnost"]); 
                    taskDetails.Add(task.Value["korisnikId"]);
                    taskDetails.Add(task.Value["vrijemePromjene"]);
                    taskDetails.Add(task.Value["zadatakId"]);

                    taskHistoryList.Add(taskDetails);
                }

                string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads", "taskHistory.txt");

                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var task in taskHistoryList)
                    {
                        writer.WriteLine($"Aktivnost: {task[0]}");
                        writer.WriteLine($"Korisnik ID: {task[1]}");
                        writer.WriteLine($"Vrijeme Promjene: {task[2]}");
                        writer.WriteLine($"Zadatak ID: {task[3]}");
                        writer.WriteLine(); 
                    }
                }
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                Environment.Exit(1);
            }
        }
    }
}
