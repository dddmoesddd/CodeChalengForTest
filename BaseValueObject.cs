public abstract class BaseValueObject
{
    // Simple equality comparison for value objects
    public override bool Equals(object obj)
    {
        return obj != null && GetType() == obj.GetType() && EqualsCore(obj);
    }

    protected abstract bool EqualsCore(object obj);

    public override int GetHashCode()
    {
        return GetHashCodeCore();
    }

    protected abstract int GetHashCodeCore();
}
