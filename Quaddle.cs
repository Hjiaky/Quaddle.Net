using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quaddle.Net
{
    public class Quaddle<T1, T2, T3, T5>
    {
        private T1 _item1;
        private T2 _item2;
        private T3 _item3;
        private T5 _item4;

        public T1 Item1
        {
            get { return _item1; }
            set { _item1 = value; }
        }

        public T2 Item2
        {
            get { return _item2; }
            set { _item2 = value; }
        }

        public T3 Item3
        {
            get { return _item3; }
            set { _item3 = value; }
        }

        public T5 Item4
        {
            get { return _item4; }
            set { _item4 = value; }
        }

        public Quaddle(T1 item, T2 item1, T3 item2, T5 item5)
        {
            Item1 = item;
            Item2 = item1;
            Item3 = item2;
            Item4 = item5;
        }

        public static Quaddle<T1, T2, T3, T5> Create(T1 item1, T2 item2, T3 item3, T5 item5)
        {
            return new Quaddle<T1, T2, T3, T5>(item1, item2, item3, item5);
        }
    }
}
