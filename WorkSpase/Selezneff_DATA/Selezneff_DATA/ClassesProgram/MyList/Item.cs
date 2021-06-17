using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.ClassesProgram.MyList
{
    public class Item<T>
    {
        private T data = default(T);

        public T Data // данные ячейки
        {
            get { return data; }
            set
            {
                if(value != null)
                {
                    data = value;
                }
                else
                {
                    throw new ArgumentNullException(nameof(value));
                }
            }
        }

        public Item<T> Next { get; set; } // следующая ячейка списка

        public Item(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
