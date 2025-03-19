using System.Xml;

namespace Algoritmos.Gestion;

public class PalindromeLargo{

    public static string AlgoritmosPalindromeLargo(string palabra){
        string palindromeLargo = string.Empty;
        for(int i = 0; i < palabra.Length; i++){
            string primerPalindrome = palindrome(palabra, i, i);
            string segundoPalindrome = palindrome(palabra, i, i+1);

            palindromeLargo = primerPalindrome.Length > segundoPalindrome.Length ? primerPalindrome : segundoPalindrome;            
        }

        return palindromeLargo;
    }

    private static string palindrome(string palabra, int izquierda, int  derecha){

        while(izquierda > 0 && derecha <= palabra.Length && palabra[izquierda] == palabra[derecha]){
            izquierda--;
            derecha++;
        }

        string resultado = palabra.Substring(izquierda, derecha - izquierda);
        Console.WriteLine(resultado);
        return resultado;
    }
}