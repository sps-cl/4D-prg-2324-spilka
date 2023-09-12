using System;

namespace Calculator
{
    public class Program
    {
        public static void Main (string[] args)
        {

        }
    }

    class Operator {
        private float a;
        private float b;

        public Operator (float a, float b) {
            this.a = a;
            this.b = b;
        }

        public float Sum(){
            return a+b;
        }

        public float odecist(){
            return a-b;
        }

        public float vynasobit(){
            return a*b;
        }

        public float vydelit(){
            try {
                return a/b;
            } catch{
                return 0;
            }
        }
    }
}