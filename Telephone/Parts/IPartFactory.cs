namespace Telephone
{
    /// <summary>
    /// Create generic variation Interface for all Factory's
    /// </summary>
    /// <typeparam name="TResult"></typeparam>
    interface IPartFactory<out TResult>
    {
        TResult Create<T>();
    }
}