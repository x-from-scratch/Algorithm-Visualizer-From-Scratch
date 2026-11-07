namespace Algorithm_Visualiser.Algorithms.Sorting;

public static class SortingAlgorithms
{
    /// <summary>
    /// Sorts an integer array using a bubble sort algorithm
    /// </summary>
    /// <param name="array">The array to be sorted</param>
    /// <returns></returns>
    public static int[] Bubble(int[] array)
    {
        /*
         * Repeatedly steps through the input list element by element,
         * comparing the current element with the one after it, swapping their values if needed.
         */

        
        // We need at most k iterations (length of the array)
        for (int i = 0; i < array.Count(); i++)
        {
            bool finished = true;
            
            for (int j = 0; j < array.Count() - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // Swap the two variables:
                    array[j] += array[j + 1];
                    array[j + 1] = array[j] - array[j + 1];
                    array[j] -= array[j + 1];
                    
                    finished = false;
                }
            }

            if (finished) break; // No need for iterations if it is sorted.
        }
        
        return array;
    }

    /// <summary>
    /// Sorts an integer array using the Insertion sort algorithm
    /// </summary>
    /// <param name="array">The array to be sorted.</param>
    /// <returns>The sorted array.</returns>
    public static int[] Insertion(int[] array)
    {
        List<int> sortedArray = new List<int>();

        foreach (int element in array)
        {
            bool inserted = false;

            for (int j = 0; j < sortedArray.Count; j++)
            {
                if (element <= sortedArray[j])
                {
                    sortedArray.Insert(j, element);
                    inserted = true;
                    break;
                }
            }

            if (!inserted) sortedArray.Add(element);
        }
        
        array = sortedArray.ToArray();
        
        return array;
    }

    /// <summary>
    /// Sorts an array using Merge sort algorithm
    /// </summary>
    /// <param name="array">Array to be sorted</param>
    /// <returns>Sorted array</returns>
    public static int[] Merge(int[] array)
    {
        return array;
    }
}