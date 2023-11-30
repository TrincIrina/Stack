using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    // класс Стек – структура данных, выполняющая функции стека фиксированного размера
    internal class Stack
    {
        // Константа - минимально допустимый размер стэка
        protected const int MIN_ALLOWED_STACK_SIZE = 10;
        // Поля
        protected object[] data;  // массив данных стэка
        protected int capacity;   // количество элементов в стэке
        protected int size;
        // Конструктор по умолчанию
        public Stack()
            : this(MIN_ALLOWED_STACK_SIZE) { }
        // Конструктор, задающий размер стэка
        public Stack(int size)
        {
            capacity = 0;
            if (size < MIN_ALLOWED_STACK_SIZE)
            {
                this.size = MIN_ALLOWED_STACK_SIZE;
                this.data = new object[this.size];
            }
            else
            {
                this.size = size;
                this.data = new object[this.size];
            }
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = 0;
            }
        }
        // Геттер - возвращает количество элементов в стэке
        public int GetCapacity()
        {
            return capacity;
        }
        // Метод добавления элемента в стэк
        public bool Push(object value)
        {
            if (capacity < size)
            {
                data[capacity++] = value;
                return true;
            }
            return false;   // Возвращает false, если стэк заполнен (capacity == data.Length)
        }
        // Метод извлечения элемента из стэка
        public object Pop(out bool ok)
        {
            if (capacity > 0)
            {
                ok = true;                
                capacity--;
                return data[capacity];
            }
            ok = false;
            return null;
        }
        // Метод возвращения крайнего элемента стэка
        public object Top(out bool ok)
        {
            if (capacity > 0)
            {
                ok = true;                
                return data[capacity - 1];
            }
            ok = false;
            return null;
        }
        // Метод вывода массива элементов стэка на экран
        public override string ToString()
        {
            string str = "";
            for(int i = 0; i < capacity; i++)
            {
                str += Convert.ToString(data[i]) + " ";
            }
            return str;
        }
    }
}
