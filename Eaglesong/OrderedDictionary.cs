using System.Collections;
using System.Collections.Generic;

namespace Eaglesong
{
    public class OrderedDictionary<T> : IEnumerable
    {
        private readonly Dictionary<string, T> _list = new Dictionary<string, T>();
        private readonly List<string> _keys = new List<string>();

        public void Add(string key, T item)
        {
            if (!this._list.ContainsKey(key))
            {
                this._keys.Add(key);
            }
            this._list[key] = item;
        }
        public T this[int i]
        {
            get
            {
                return this._list[this._keys[i]];
            }
        }
        public T this[string key]
        {
            get
            {
                return this._list[key];
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
            return this._keys.GetEnumerator();
        }
    }
}
