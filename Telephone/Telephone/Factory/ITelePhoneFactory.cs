namespace Telephone
{
    interface ITelePhoneFactory<out TResult>
    {
        TResult Create<T>();
    }
}