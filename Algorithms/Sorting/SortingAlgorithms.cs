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
        for (int i = 0; i < array.Length; i++)
        {
            bool finished = true;
            
            for (int j = 0; j < array.Length - 1; j++)
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
    /// Sorts an array using the bubble sort algorithm while tracking the step.
    /// </summary>
    /// <param name="array">The array to be sorted</param>
    /// <param name="track">Whether to track or not the steps.</param>
    /// <returns>The sorted array with a dictionary containing steps.</returns>
    public static (int[], List<Step>) Bubble(int[] array, bool track)
    {
        // If not tracking use the old algorithm.
        if (!track) return (Bubble(array), null);

        List<Step> stepsList = new List<Step>();
        
        for (int i = 0; i < array.Length; i++)
        {
            bool finished = true;
            
            for (int j = 0; j < array.Length - 1; j++)
            {
                // We will compare the two variables, so store this as a step.
                stepsList.Add(new (StepKind.Compare, j, j + 1));
                if (array[j] > array[j + 1])
                {
                    // Here we will swap the two variables.
                    stepsList.Add(new (StepKind.Swap, j, j + 1));
                    
                    // Swap the two variables:
                    array[j] += array[j + 1];
                    array[j + 1] = array[j] - array[j + 1];
                    array[j] -= array[j + 1];
                    
                    finished = false;
                }
            }

            if (finished) break; // No need for iterations if it is sorted.
        }
        
        return (array,  stepsList);
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

    #region Merge sort
    
    /// <summary>
    /// Sorts an array using Merge sort algorithm
    /// </summary>
    /// <param name="array">Array to be sorted</param>
    /// <returns>Sorted array</returns>
    public static int[] Merge(int[] array)
    {
        MergeSort(array, 0, array.Length - 1);
        return array;
    }

    private static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            // Find the middle point:
            int middle = (left + right) / 2;
            
            // Merge first and second half.
            MergeSort(array, left, middle);
            MergeSort(array, middle + 1, right);
            
            // Merge the sorted halves
            _Merge(array, left, middle, right);
        }
    }

    private static void _Merge(int[] array, int left, int middle, int right)
    {
        // Find the sizes of the two subarrays to be merged.
        int n1 = middle - left + 1;
        int n2 = right - middle;
        
        // Create temporary arrays:
        int[] tempLeft = new int[n1];
        int[] tempRight = new int[n2];

        for (int index = 0; index < n1; index++)
        {
            tempLeft[index] = array[left + index];
        }

        for (int index = 0; index < n2; index++)
        {
            tempRight[index] = array[middle + 1 + index];
        }
        
        // Merge the temporary arrays:
        int i = 0, j = 0; // Indices

        int k = left;

        while (i < n1 && j < n2)
        {
            if (tempLeft[i] <= tempRight[j])
            {
                array[k] = tempLeft[i];
                i++;
            }
            else
            {
                array[k] = tempRight[j];
                j++;
            }

            k++;
        }
        
        // Copy remaining elements of L[] if any
        while (i < n1) {
            array[k] = tempLeft[i];
            i++;
            k++;
        }

        // Copy remaining elements of R[] if any
        while (j < n2) {
            array[k] = tempRight[j];
            j++;
            k++;
        }
    }
    
    #endregion
    
    
    
}