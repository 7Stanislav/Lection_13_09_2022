//массив по умолчанию наполнен нулями, поэтому, чтобы его заполнить - мы воспользуемся методом, который сами напишем
void FillArray(int[] collection)
{
    int length = collection.Length; // получаем длину массива
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); // новое случайное целое число из диапазона 1-10
        index++;
    }
}

void PrintArray(int[] col) //Метод, который печатает массив
{
    int count = col.Length; //Количество элементов
    int position = 0; //Текущая позиция
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position ++;
    }

}

int[] array = new int [10]; // определим новый масив и укажем, что в нем 10 элементов

FillArray(array);
PrintArray(array);
