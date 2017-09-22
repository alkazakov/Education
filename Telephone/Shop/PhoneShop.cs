namespace Telephone
{
    partial class Program
    {
        private class PhoneShop 
        {
            public IPhone GetPhone<T>()
            {
                PhoneFactory phoneFactory = new PhoneFactory();
                if (typeof(T) == typeof(Phone))
                {
                    
                    var manufacturer = phoneFactory.Create<PrimitiveManufacturer>();
                    PrimitivePhoneConcreteBuilder builder = new PrimitivePhoneConcreteBuilder();
                    manufacturer.Construct(builder);
                    return builder.GetResult();
                }
                else 
                {
                    var manufacturer = phoneFactory.Create<SamsungManufacturer>();
                    SamsungPhoneConcreteBuilder builder = new SamsungPhoneConcreteBuilder();
                    manufacturer.Construct(builder);
                    return builder.GetResult();

                }
               

            }
        }
    }
}