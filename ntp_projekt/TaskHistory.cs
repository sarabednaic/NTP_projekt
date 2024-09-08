using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace ntp_projekt
{
    internal class TaskHistory
    {
        public int id;
        public string korisnikId;
        public string vrijemePromjene;
        public string aktivnost;
        public string zadatakId;

        public TaskHistory(string _korisnikId, string _vrijemePromjene, string _aktivnost, string _zadatakId)
        {
            korisnikId = _korisnikId;
            vrijemePromjene = _vrijemePromjene;
            aktivnost = _aktivnost;
            zadatakId = _zadatakId;
        }

        public static List<TaskHistory> getHistory()
        {
            var client = new HttpClient();
            var url = "https://projecthistoryteamplan-default-rtdb.firebaseio.com/taskHistory.json";
            var response = client.GetAsync(url).Result;

            var responseJson = response.Content.ReadAsStringAsync().Result;
            var responseBody = JsonConvert.DeserializeObject<List<TaskHistory>>(responseJson);

            return responseBody;

        }

        public static TaskHistory saveHistory(TaskHistory newTask)
        {

            using (var client = new HttpClient())
            {

                var url = "https://projecthistoryteamplan-default-rtdb.firebaseio.com/taskHistory.json";

                var response = client.PostAsJsonAsync(url, new {zadatakId = newTask.zadatakId, korisnikId = newTask.korisnikId, aktivnost = newTask.aktivnost, vrijemePromjene = newTask.vrijemePromjene }).Result;

                if (response.IsSuccessStatusCode)
                { 
                    return null;
                }

                MessageBox.Show("ERROR");
                return null;
            }


        }


    }
}
