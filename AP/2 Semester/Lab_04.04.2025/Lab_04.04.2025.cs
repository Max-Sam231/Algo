// Необходимо реализовать обобщенный класс, который позволяет хранить в массиве объекты любого типа.
// В данном классе определить методы для добавления данных в массив, удаления из массива, получения элемента по индексу

internal class Program
{
    public class DinamicArray<T>
    {
        private T[] items = Array.Empty<T>();
        private int count = 0;

        public void AddElem(T item)
        {
            if (count == items.Length)
            {
                Array.Resize(ref items, count == 0 ? 4 : items.Length * 2);
            }
            items[count] = item;
            count++;
        }
        public void RemoveElem(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы массива.");
            for (int i = index; i < count; i++)
            {
                items[i] = items[i + 1];
            }
            count--;
            items[count] = default;
        }
        public T SearchElem(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Индекс выходит за границы массива.");
            return items[index];
        }
    }
    static void Main(string[] args)
    {
        DinamicArray<int> array = new DinamicArray<int>();
        array.AddElem(10);
        array.AddElem(15);
        array.AddElem(20);
        Console.WriteLine(array.SearchElem(0));

        array.RemoveElem(0);
        Console.WriteLine(array.SearchElem(0));

    }
}

