namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region IShape Example
            // IShape circle = new Circle(5);
            // IShape rectangle = new Rectangle(4, 6);
            // rectangle.Area();
            // Console.WriteLine($"Perimeter: {rectangle.Perimeter()}");
            // circle.Area();
            //Console.WriteLine($"Perimeter: {circle.Perimeter()}");
            #endregion

            #region IPaymentGateway Example
            //IPaymentGateway creditCardPayment = new CreditCardPayment();
            //creditCardPayment.ProcessPayment(100.0);
            //IPaymentGateway PayPalpayment = new PayPalPayment();
            //PayPalpayment.ProcessPayment(200.0);
            #endregion
            #region ICalculator Example
            //Calculator<int> intCalculator = new Calculator<int>();
            //Console.WriteLine( Calculator<int>.Add(5, 10));
            //Calculator<double> doubleCalculator = new Calculator<double>();
            //Console.WriteLine(Calculator<double>.Add(5.5, 10.3));
            #endregion

            #region Stack
            MyStack<int> intStack = new MyStack<int>(3);

            intStack.Push(10);
            intStack.Push(20);
            intStack.Push(30);


            intStack.Display();

            Console.WriteLine("Popped: " + intStack.Pop());
            intStack.Display();

            Console.WriteLine("----------------");

            
            MyStack<string> stringStack = new MyStack<string>(2);

            stringStack.Push("Ali");
            stringStack.Push("Sara");
            stringStack.Push("Omar"); 

            stringStack.Display();

            Console.WriteLine("Popped: " + stringStack.Pop());
            stringStack.Display();


            #endregion



        }
    }
}