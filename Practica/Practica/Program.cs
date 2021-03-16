using System;

namespace Practica
{
    class Program
    {
        static void Main(string[] args)
        {   //For traditional
            // for(int i = 0; i<10; i++)
            // {
            //     Console.WriteLine($"{i} \t");
            // }
            
            for(int i=0, j=1; i<10; i+=2, j+=2)
            {
                Console.WriteLine($"{i}\t{j}");
            }

            // for(int i= 10, j=0; i>=0; i--,j++){
            //     Console.WriteLine($"{i}\t{j}");
            // }  


            var word = "anita lava la tina";
            var vowels = 0;

            for(int i = 0; i<word.Length; i++)
                if(word[i] =='a' || word[i] =='e' || word[i] =='i' || word[i] =='o' || word[i] =='u')
                    vowels++;

            var vowelsInOrder = string.Empty;
            for(int i = 0; i<word.Length; i++)
                if(word[i]=='a' || word[i]=='e' || word[i]=='i' || word[i]=='o' || word[i]=='u')
                    vowelsInOrder += $"{word[i]}";

            Console.WriteLine($"Vowels: {vowels}");
            Console.WriteLine($"Vowels in appering order: {vowelsInOrder}");
    }
}
}
