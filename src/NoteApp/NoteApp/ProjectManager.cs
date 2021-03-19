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
        private const string Filename = @"..\My Documents\NoteApp.notes";

        public static void SaveToFile(Project data)
        {
            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter sw = new StreamWriter(Filename))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, data);
            }
        }

        public static Project LoadFromFile()
        {
            var project = new Project();

            JsonSerializer serializer = new JsonSerializer();

            using (StreamReader sr = new StreamReader(Filename))
            using (JsonReader reader = new JsonTextReader(sr))
            {
                project = serializer.Deserialize<Project>(reader);
            }

            return project;
        }
    }
}
