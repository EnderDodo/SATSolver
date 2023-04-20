namespace SATSolver;

public class Clause
{
    public HashSet<Literal> Literals;
    public bool IsUnitClause => Literals.Count == 1;
    public bool IsEmptyClause => Literals.Count == 0;

    public Clause(params Literal[] literals)
    {
        Literals = new HashSet<Literal>(literals);
    }
    
    
}