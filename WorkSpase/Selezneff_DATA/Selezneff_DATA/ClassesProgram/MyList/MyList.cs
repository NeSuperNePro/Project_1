using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selezneff_DATA.ClassesProgram.MyList
{
    public class MyList<T> : IEnumerable
    {
        public Item<T> Head { get; private set; }// первый элемент списка
        public Item<T> Tail { get; private set; }// последний элемент списка
        public int Count { get; private set; }// количество эелементов в списке

        public MyList()// создание пустого списка
        {
            Clear();
        }

        public MyList(T data)// создание списка с начальным элементом
        {
            SetHeadAndTail(data);
        }

        public void Add(T data)// добавление в список
        {
            if(Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void Delete(T data)// удаление элемента из списка
        {
            if(Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }

                var current = Head.Next;
                var previous = Head;
                                
                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                SetHeadAndTail(data);
            }
        }

        public void Clear()// очистка списка
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void AppendHead(T data)// добавление элемента в начало списка списка
        {
            var item = new Item<T>(data) { Next = Head };

            Head = item;
            Count++;
        }

        public void InsertAfter(T target, T data)// добавление эелемента между элементами списка
        {
            if (Head != null)
            {
                var current = Head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        item.Next = current.Next;
                        current.Next = item;
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator GetEnumerator()// получение перечесление всех элементов списка
        {
            var current = Head;
            while(current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        public override string ToString()
        {
            return "My List " + Count + " элементов";
        }
        
    }
}
