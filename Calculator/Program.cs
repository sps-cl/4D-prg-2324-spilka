namespace Calculator
{
    public class Program
    {
        public static void Main (string[] args)
        {
            Console.WriteLine("Prvni cislo: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Druhe cislo: ");
            int y = int.Parse(Console.ReadLine());
            
            CalculatorContext calc = new CalculatorContext(new OpAdd());
            Console.WriteLine("OpAdd: "+calc.Execute(x, y));
            calc.SetOperator(new OpSub());
            Console.WriteLine("OpSub: "+calc.Execute(x, y));
            calc.SetOperator(new OpMagic());
            Console.WriteLine("OpMagic: "+calc.Execute(x, y));
        }
    }

    public interface IOperator {
        double Execute (int a, int b);
    }

    public class OpAdd : IOperator {
        public double Execute (int a, int b){
            return a+b;
        }
    }

    public class OpSub : IOperator {
        public double Execute (int a, int b){
            return a-b;
        }
    }

    public class OpMagic : IOperator {
        public double Execute (int a, int b){
            return a*b;
        }
    }

    public class OpMultiply : IOperator {
        public double Execute(int a, int b) { 
            return a*b;
        }
    }

    public class CalculatorContext {
        private IOperator ioperator;
        
        public CalculatorContext(IOperator ioperator) {
            this.ioperator = ioperator;
        }

        public void SetOperator(IOperator ioperator) {
            this.ioperator = ioperator;
        }

        public double Execute(int a, int b) {
            return ioperator.Execute(a, b);
        }
    }
}