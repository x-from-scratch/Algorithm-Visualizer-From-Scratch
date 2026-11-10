namespace Algorithm_Visualiser.Algorithms.Sorting;

public enum StepKind
{
    Compare, 
    Swap,
}

public record Step(StepKind Kind, int I, int J)
{
   
}