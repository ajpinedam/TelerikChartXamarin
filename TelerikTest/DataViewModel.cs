using System.Collections.ObjectModel;
using System.Linq;

namespace TelerikTest
{
    public class DataViewModel
    {
        public ObservableCollection<Data> MyData { get; set; } = new ObservableCollection<Data> ();

        public int Count => !MyData.IsEmpty () ? MyData.Count : 0;

        public double ItemsSum => !MyData.IsEmpty () ? MyData.ToList ().Sum (a => a.Value) : 0;

        public DataViewModel ()
        {
            MyData = CreateData ();
        }

        public static ObservableCollection<Data> CreateData ()
        {
            var collection = new ObservableCollection<Data>
            {
                new Data { Category = "Apples", Value = 10, LabelProperty = "First Point" },
                new Data { Category = "Oranges", Value = 8, LabelProperty = "Second Point" },
                new Data { Category = "Cherry", Value = 3, LabelProperty = "Third Point" },
                new Data { Category = "Pineapples", Value = 21, LabelProperty = "Fourth Point"}
            };

            return collection;
        }
    }
}

