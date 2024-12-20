using System;
namespace Array{
    class Program{
        static void Main(string[]args){           
            Console.Clear();
            var meuArray = new int[5];
            meuArray[0]=12;
            meuArray[1]=12;
            meuArray[2]=10;
            meuArray[3]=11;
            Console.WriteLine(meuArray[0]);
            Console.WriteLine(meuArray[1]);
            Console.WriteLine(meuArray[2]);
            Console.WriteLine(meuArray[3]);
            var Array = new int[5]{10,20,30,40,50};
            Console.WriteLine(Array[0]);
            Console.WriteLine(Array[1]);
            Console.WriteLine(Array[2]);
            Console.WriteLine(Array[3]);
            Console.WriteLine(Array[4]);
            for(var item = 0;item< Array.Length ;item++){
                Console.WriteLine(Array[item]);
            }
            foreach (var item in Array)//foreach e a melhor forma de percorrer o Array 
            {
                Console.WriteLine(Array[item]);
            }
            
                

            
            
           

        }
    }
}