namespace Assignment_C__Advanced_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // Genaric class => is class with unKnown data type and specify this type when creating an object
            #endregion

            #region Q2
            // 
            #endregion

            #region Q3
            // use multiple type of unknown data (Genercs data)
            #endregion

            #region Q4
            // this method with unknown tipe is specify when call this method
            swap swap = new swap();
            int a = 20;
            int b = 30;

            swap.swap1<int>(ref a, ref b);
            Console.WriteLine($"A : {a}, B : {b}");
            #endregion

            #region Q5
            // i do not know if
            #endregion

            #region Q6
            // this is interface with unKnown data type and specify this type when implement this interface

            #endregion

            #region Q7
            // this is type of Generics use to defined value type only
            #endregion

            #region Q8
            // this is type of Generics use to defined Reference type only
            #endregion

            #region Q9
            // this is type of Generics and the class must not have a constractor 
            #endregion

            #region Q10
            // this is type of Generics and must implement this interface
            #endregion

            #region Q11
            // T must inherit from a specific class
            #endregion

            #region Q12
            // example of constraints => public class MultipleConstraints <T> where T : Swap , interfaceconstraints
            #endregion

            #region Q13
            // if value is refernce retun null ; if value is value type return 0;
            #endregion

            #region Q14
            Safelist<int> safelist = new Safelist<int>();
            safelist.add(10);
            safelist.add(20);
            Console.WriteLine(safelist.get(0));
            Console.WriteLine(safelist.get(4));
            #endregion

            #region Q15
            // out keyword to specify that the type parameters is used only as output
            #endregion

            #region Q16
            // in keyword to specify that the type parameters is used only as input
            #endregion

            #region Q17
            // covarince is used to assign output only , but contravariance is used to assign input only
            #endregion




        }
    }
}
