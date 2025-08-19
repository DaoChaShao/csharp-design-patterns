namespace A.SOLID.B.Open.And.Closed.Principle;

// This interface is used to judge whether an item is consistent.
internal interface ISpecification<in T>
{
    bool IsConsistent(T item);
}