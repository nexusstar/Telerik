namespace TestGenerics
{
    public class GenericClass<T, K> 
        where T: class
        where K: class
    {
        private T someData;
        private K someOtherData;

        public GenericClass(T data, K otherData)
        {
            this.someData = data;
            this.someOtherData = otherData;
        }

    }
}
