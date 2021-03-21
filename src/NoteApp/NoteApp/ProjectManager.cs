using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace NoteApp
{
    public static class ProjectManager
    {
        private const string Filename = "NoteApp.notes";

        public static string DefaultPath { get; set; } = 
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), 
                "NoteApp", Filename);

        public static void SaveToFile(Project data, string path)
        {
            if(!Directory.Exists(Path.GetDirectoryName(path)))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, data);
            }
        }

        public static Project LoadFromFile(string path)
        {
            Project project = null;

            JsonSerializer serializer = new JsonSerializer();

            if (!File.Exists(path))
            {
                return new Project();
            }

            try
            {
                using (StreamReader sr = new StreamReader(path))
                using (JsonReader reader = new JsonTextReader(sr))
                {
                    project = serializer.Deserialize<Project>(reader);
                }
            }
            catch(Exception)
            {
                return new Project();
            }

            return project ?? new Project();
        }
    }
}
