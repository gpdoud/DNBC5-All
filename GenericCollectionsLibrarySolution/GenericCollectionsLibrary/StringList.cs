using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionsLibrary {

    public class StringList : List<string> {

        public void Add(params string[] strs) {
            foreach(var str in strs) {
                base.Add(str);
            }
        }
        public void Add(string str1, string str2, string str3, string str4) {
            this.Add(str1, str2, str3);
            base.Add(str4);
        }
        public void Add(string str1, string str2, string str3) {
            this.Add(str1, str2);
            base.Add(str3);
        }
        public void Add(string str1, string str2) {
            base.Add(str1);
            base.Add(str2);
        }

        public StringList() : base() {

        }
    }
}
