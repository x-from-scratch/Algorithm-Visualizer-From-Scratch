using Xunit;
using Algorithm_Visualiser.Algorithms.Sorting;

namespace Algorithm_Visualiser.Tests;

public class SortingTests
{
    [Fact]
    public void BubbleSort()
    {
        int[] input = { 5, 9, 2, 1, 8 };
        int[] input2 = { 1, 2, 1, 2, 1 };
        
        Assert.Equal(new int[]{1, 2, 5, 8, 9}, SortingAlgorithms.Bubble(input));
        Assert.Equal(new int[]{1, 1, 1, 2, 2}, SortingAlgorithms.Bubble(input2));
    }

    [Fact]
    public void InsertionSort()
    {
        int[] input = { 5, 9, 2, 1, 8 };
        int[] input2 = { 1, 2, 1, 2, 1 };
        
        Assert.Equal(new int[]{1, 2, 5, 8, 9}, SortingAlgorithms.Insertion(input));
        Assert.Equal(new int[]{1, 1, 1, 2, 2}, SortingAlgorithms.Insertion(input2));
    }
}
