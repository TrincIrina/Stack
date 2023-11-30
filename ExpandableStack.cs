using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // Расширяемый стэк - наследник класса Стэк
    internal class ExpandableStack : Stack
    {
        // Константа - расширение стэка по умолчанию
        private const double DEFAULT_GROW_COEFFICIENT = 1.2;
        
        private double grow_coefficient;  // коэфициент расширения стэка
        // Конструктор по умолчанию 
        public ExpandableStack()
            : this(MIN_ALLOWED_STACK_SIZE) { }
        // Конструктор, задающий размер стэка
        public ExpandableStack(int size)
            : base(size)
        {
            grow_coefficient = DEFAULT_GROW_COEFFICIENT;
        }
        // Конструктор, задающий размер стэка и коэфициент расширения
        public ExpandableStack(int size, double grow_coefficient)
            : base(size)
        {
            if(grow_coefficient > 1.0)
            {
                this.grow_coefficient = grow_coefficient;
            }
            else
            {
                this.grow_coefficient = DEFAULT_GROW_COEFFICIENT;
            }
        }
        // Геттер - возвращает размер стэка
        public int GetSize()
        {
            return size;
        }
        // Метод добавления элемента
        public new bool Push(object value)
        {
            if (capacity == size)   // Если стэк заполнен - производим расширение
            {
                size = Convert.ToInt32(Convert.ToDouble(size) * grow_coefficient);
                object[] arr = new object[size];
                for(int i = 0; i < data.Length; i++)
                {
                    arr[i] = data[i];
                }
                for (int i = data.Length; i < size; i++)
                {
                    arr[i] = 0;
                }
                data = arr;
            }
            data[capacity++] = value;
            return true;
        }
        // Метод ужатия ёмкости стэка
        public void Shrink()
        {
            if (size > capacity)
            {
                size = capacity;
            }
        }
    }
}
