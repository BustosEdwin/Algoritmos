namespace Algoritmos.Gestion;

public class ZipZap{

    public static string AlgorimoZipZap(int filas, string palabra){

        string[] lstFilas = new string[filas];
        int row = 0;
        bool banderaZipZap = false;

        for(int i = 0; i < palabra.Length; i++){
            lstFilas[row] += palabra[i];
            if(row == 0 || row == lstFilas.Length - 1)
                banderaZipZap = !banderaZipZap;
            row += banderaZipZap ? 1 : -1;
        }

        return string.Join("", lstFilas);   
    }
}