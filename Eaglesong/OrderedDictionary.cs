using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eaglesong
{
    public class OrderedDictionary<T> : IEnumerable
    {
        private Dictionary<string, T> list = new Dictionary<string, T>();
        private List<string> keys = new List<string>();

        public void Add(string key, T item)
        {
            if (!this.list.ContainsKey(key))
            {
                this.keys.Add(key);
            }
            this.list[key] = item;
        }
        public T this[int i]
        {
            get
            {
                return this.list[keys[i]];
            }
        }
        public T this[string key]
        {
            get
            {
                return this.list[key];
            }
            set
            {
                this.Add(key, value);
            }
        }

        /// <summary>
        /// Force the iterator to enumerate in index order
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            foreach (string key in this.keys)
            {
                yield return this.list[key];
            }
        }
    }
}
