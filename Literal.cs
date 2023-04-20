namespace SATSolver;

public class Literal
{
    public int Index { get; }
    public bool Sign { get; }

    public Literal(int index, bool sign)
    {
        Index = index;
        Sign = sign;
    }
}