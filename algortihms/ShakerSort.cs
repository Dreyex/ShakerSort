namespace algorithms;

public class ShakerSort
{
    public int[] sort(int[] array)
    {
        output(array);
        int beginIndex = -1;
        int endIndex = array.Length - 2;
        Boolean swapped;
        do
        {
            swapped = false;
            beginIndex++;
            for(int i = beginIndex; i <= endIndex; i++)
            {
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true;
                }
                output(array);
            }
            if(!swapped)
            {
                return array;
            } 
            swapped = false;
            endIndex--;
            for(int i = endIndex; i >= beginIndex; i--)
            {
                //Console.WriteLine(i);
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true;
                }
                output(array);
            }
        } while (swapped);
        output(array);
        return array;
    }

    private void swap(int index, int[] array)
    {
        int temp = array[index + 1];
        array[index + 1] = array[index];
        array[index] = temp;
    }

    public void output(int[] array)
    {
        foreach(int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

}