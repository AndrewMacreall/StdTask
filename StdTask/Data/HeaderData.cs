using Newtonsoft.Json;
using StdTask.Views;
using StdTask.Enums;
using System.ComponentModel;

namespace StdTask.Data
{
    public class HeaderData
    {
        [JsonProperty("type")]
        public ColumnType ColumnType { get; set; } // тип поля ячейки
        [JsonProperty("name")]
        public string Name { get; set; } // имя заголовка
        [JsonProperty("text")]
        public string Text { get; set; } // текст заголовка
        [JsonProperty("read")]
        public bool ReadOnly { get; set; } // отображание в дочерних формах и возможность редактирования данных
        public bool Visible { get; set; } // отображение в основной форме
        [JsonProperty("view")]
        public View View { get; set; }
    }
}
