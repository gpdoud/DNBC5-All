using GenericCollectionsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGenericCollectionsLibrary {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine(GenericCollections.About);

            var stringDictionary = new StringDictionary();
            stringDictionary.Add(7, "Irena");
            stringDictionary.Add(4, "Sammy");
            stringDictionary.Add(25, "Ben");
            stringDictionary.Add(42, "Seth");
            stringDictionary.Add(97, "Ken");
            stringDictionary.Add(55, "Kellan");
            stringDictionary.Add(3, "Chris");

            var a = stringDictionary.Get(42);

            Console.WriteLine($"The person with the fav nbr of 42 is {stringDictionary.Get(42)}");

            foreach(var data in stringDictionary.Values()) {
                Console.WriteLine(data);
            }

            var strings = new StringList();
            strings.Add("abc");
            strings.Add("def");
            strings.Add("ghi");
            strings.Add("xxx", "yyy");
            strings.Add("aaa", "bbb", "ccc", "ddd", "eee", "fff");
            foreach(var str in strings) {
                Console.WriteLine(str);
            }
        }
    }
}
