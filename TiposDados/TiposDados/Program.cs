using System;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            bool completo = false; // Dados Boleanos
            char genero = 'F'; // Dados com uma letra só, tem que estar entre aspas simples
            byte n1 = 126; //Numeros que vao de 0 a 255
            int n2 = 1000; // Numeros inteiros de ate 32bits
            int n3 = 2147483647; 
            long n4 = 2147483648L; // numero inteiro maior que int, de 64bits
            float n5 = 4.5f; //decimal de ate 32 bits
            double n6 = 4.5; // decimal de 64 bits
            String nome = "Maria Green"; // texto em aspas duplas
            Object obj1 = "Alex Brown"; // object é um tipo generico, pode receber qualquer tipo de variavei
            Object obj2 = 4.5f;


            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            


        }
    }
}