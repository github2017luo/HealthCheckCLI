using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using HealthCheckCLI.Models;

namespace HealthCheckCLI.Data.Repositories
{
    
    public class Repository : IRepository
    {
        private const string File = "datastore.json";    
        
        public void Save<T>(T item)
        {
            SetupSettings();

            var readData = System.IO.File.ReadAllText(File);

            var data = JsonSerializer.Deserialize<Models.Data>(readData);

            switch (item)
            {
                case Group group:
                    SaveGroup();
                    break;
                case Url url:
                    SaveUrl(url, data);
                    break;
            }
        }

        private void SaveGroup()
        {
            
        }

        private void SaveUrl<T>(T item, Models.Data data) where T : DataItem
        {
            if (IsExists(item, data)) return;
            
            data.Urls.Add(item as Url);
            
        }

        private bool IsExists<T>(T item, Models.Data data) where T : DataItem
        {
            return data.Groups.Any(x => x.Id == item.Id) 
                   || data.Urls.Any(x => x.Id == item.Id);
        }
        

        private void SetupSettings()
        {
            if (System.IO.File.Exists(File)) return;
            
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var template = JsonSerializer.Serialize(new Models.Data(), options);

            System.IO.File.WriteAllText(File, template);
        }
    }

    public interface IRepository
    {
        
    }
}