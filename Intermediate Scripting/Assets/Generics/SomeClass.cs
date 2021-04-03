namespace Generics
{
    public class SomeClass 
    {
        //Here is a generic method. Notice the generic
        //type 'T'. This 'T' will be replaced at runtime
        //with an actual type. 
        public T GenericMethod<T>(T param)
        {
            return param;
        }
        
        /* public T GenericMethod<T>(T param) where T : class
        {
            return param;
        }*/
        
        /* public T GenericMethod<T>(T param) where T : struc
        {
            return param;
        }*/
        
        /* public T GenericMethod<T>(T param) where T : New()
        {
            return param;
        }*/
        
        /* public T GenericMethod<T>(T param) where T : MonoBehaviour
        {
            return param;
        }*/
        
        /* public T GenericMethod<T>(T param) where T : IEnumerator
        {
            return param;
        }*/
    }
}
