namespace Telephone
{
    partial class Program
    {
        private interface IPhoneShop<out TResult>
        {
            TResult GetPhone<T>();
        }
    }
}