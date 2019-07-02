using System.IO;
using Newtonsoft.Json;

namespace StdTask.Views
{
    class FileManager<T>
    {
        private string path;
        /* Конструктор */
        public FileManager(string path)
        {
            this.path = path;
        }
        /* Загрузка объектов */
        public T OpenAllText()
        {
            var jSettings = new JsonSerializerSettings(); // настройки json
            jSettings.TypeNameHandling = TypeNameHandling.Auto; // для загрузки abstract классов

            return JsonConvert.DeserializeObject<T>(File.ReadAllText(path), jSettings);
        }
        public T[] OpenAllLines()
        {
            string[] data = File.ReadAllLines(path);
            T[] result = new T[data.Length];

            for (int i = 0; i < data.Length; i++) {
                result[i] = JsonConvert.DeserializeObject<T>(data[i]);
            }

            return result;
        }
        /* Сохранение объектов */
        public void SaveAllText(T obj)
        {
            var jSettings = new JsonSerializerSettings(); // настройки json
            jSettings.TypeNameHandling = TypeNameHandling.Auto; // для сохранения abstract классов

            File.WriteAllText(path, JsonConvert.SerializeObject(obj, jSettings));
        }
        public void SaveAllLines(T[] objs)
        {
            string[] result = new string[objs.Length];

            for (int i = 0; i < objs.Length; i++) {
                result[i] = JsonConvert.SerializeObject(objs[i]);
            }

            File.WriteAllLines(path, result);
        }

    }
}
