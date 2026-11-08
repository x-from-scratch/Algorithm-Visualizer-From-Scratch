using Algorithm_Visualiser.Algorithms.Sorting;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace Algorithm_Visualiser.Tests;

public class SortingTests
{
    private static readonly int[] Input1 = [5, 9, 2, 1, 8];
    private static readonly int[] Input2 = [3, 1, 2, 1, 2, 1];
    
    private static readonly int[] Expected1 = [1, 2, 5, 8, 9];
    private static readonly int[] Expected2 = [1, 1, 1, 2, 2, 3];

    [Fact]
    public void BubbleSort()
    {
        Assert.Equal(Expected1, SortingAlgorithms.Bubble((int[])Input1.Clone()));
        Assert.Equal(Expected2, SortingAlgorithms.Bubble((int[])Input2.Clone()));
    }
    

    [Fact]
    public void InsertionSort()
    {
        Assert.Equal(Expected1, SortingAlgorithms.Insertion((int[])Input1.Clone()));
        Assert.Equal(Expected2, SortingAlgorithms.Insertion((int[])Input2.Clone()));
    }

    [Fact]
    public void MergeSort()
    {
        Assert.Equal(Expected1, SortingAlgorithms.Merge((int[])Input1.Clone()));
        Assert.Equal(Expected2, SortingAlgorithms.Merge((int[])Input2.Clone()));
    }
}
