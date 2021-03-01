using System;

namespace FactoryPatterBasic
{
    public interface IProduct
    {
        string Name { get; set; }
        void DoWork();
    }

    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();
    }

    public class ConcretProduct : IProduct
    {
        public string Name { get; set; }

        public void DoWork()
        {
            Console.WriteLine("Do Concret work");
        }
    }

    public class ConcretCreator : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcretProduct();
        }
    }
}
