namespace algorithms;

public class ShakerSort
{
    int loop = 1;
    public int[] sort(int[] array)      //Sort with numerical output
    {
        output(array);                      //Array output in original order/state
        int beginIndex = -1;                //Starting index in array
        int endIndex = array.Length - 2;    //End index in array
        Boolean swapped;                    //Got something swapped
        do
        {
            swapped = false;                
            beginIndex++;                   //Start index in array gets incremented by 1 every loop
                                            //nothing gets checked twice
            for(int i = beginIndex; i <= endIndex; i++)     //Check and swap upwards if necessary
            {
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true; 
                    output(array);                        //swapped = true, so the loop goes on
                }
            }
            if(!swapped)                                    //only happens when array is sorted, breaks the while when its sorted after upwards
            {
                return array;                               //return the array when it is sorted
            } 
            swapped = false;                                //set it to false so if the array is sorted after the first for, the loop breaks
            endIndex--;                                     //last element is sorted
            for(int i = endIndex; i >= beginIndex; i--)     //Check and swap downwards if necessary
            {
                //Console.WriteLine(i);                     
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true;
                    output(array);
                }
            }
        } while (swapped);      //foot controlled while loop, because it needs to be looped at least once
                                //breaks if nothing gets changed downwards
        output(array);          
        return array;
    }


public int[] sortBar(int[] array)      //Sort with bar graph output
    {
        graphicalOutput(array);                      //Array output in original order/state
        int beginIndex = -1;                //Starting index in array
        int endIndex = array.Length - 2;    //End index in array
        Boolean swapped;                    //Got something swapped
        do
        {
            swapped = false;                
            beginIndex++;                   //Start index in array gets incremented by 1 every loop
                                            //nothing gets checked twice
            for(int i = beginIndex; i <= endIndex; i++)     //Check and swap upwards if necessary
            {
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true;   
                    graphicalOutput(array);                      //swapped = true, so the loop goes on
                }
            }
            if(!swapped)                                    //only happens when array is sorted, breaks the while when its sorted after upwards
            {
                return array;                               //return the array when it is sorted
            } 
            swapped = false;                                //set it to false so if the array is sorted after the first for, the loop breaks
            endIndex--;                                     //last element is sorted
            for(int i = endIndex; i >= beginIndex; i--)     //Check and swap downwards if necessary
            {
                //Console.WriteLine(i);                     
                if(array[i] > array[i + 1])
                {
                    swap(i, array);
                    swapped = true;
                    graphicalOutput(array);
                }
            }
        } while (swapped);      //foot controlled while loop, because it needs to be looped at least once
                                //breaks if nothing gets changed downwards
        graphicalOutput(array);          
        return array;
    }


    private void swap(int index, int[] array)
    {
        int temp = array[index + 1];
        array[index + 1] = array[index];
        array[index] = temp;
    }

    private void output(int[] array)            //Output every element in the array
    {
        Console.WriteLine(loop + ". Swap");
        loop++;
        foreach(int element in array)
        {
            Console.Write(element + " ");
        }   
        Console.WriteLine();   
        Console.WriteLine();                    //print empty lines so the next output doesnt clip onto it
    }

    private void graphicalOutput(int[] array)   //Output the array graphically in the Console
    {                                           //Note that values greater than 10 will have a large output as result
        Console.WriteLine(loop + ". Swap");
        loop++;
        foreach(int element in array)
        {
            for(int i = element; i >= 0; i--)      //write an "|" the scale of the element
            {
                Console.Write("|");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

}