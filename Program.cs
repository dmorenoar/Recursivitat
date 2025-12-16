static class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(SumaIt(4));

        Console.WriteLine(SumaRec(4));

        CountdownEvent(10);
    }

    /*Versió iterativa*/
    public static int SumaIt(int n)
    {
        int num = 0;

        for(int i = 1; i <= n; i++)
        {
            num += i;
        }
        return num;
    }

    /*Versió recursiva
     Una funció recursiva és una funció:
        - Es crida a si mateixa
        - Sempre ha de tenir un cas base que aturi les crides, en cas contrari, recursió infinita.

    Fase de baixada (crides) amb SumaRec(4):

    SumaRec(4) = 4 + SumaRec(4 - 1) = 4 + SumaRec(3)
    SumaRec(3) = 3 + SumaRec(3 - 1) = 3 + SumaRec(2)
    SumaRec(2) = 2 + SumaRec(2 - 1) = 2 + SumaRec(1)
    SumaRec(1) = 1 + SumaRec(1 - 1) = 1 + SumaRec(0)
    SumaRec(0) = 0   <- cas base

    NOTA: Aquí no es calcula res encara, només es van acumulant crides (com una pila de tasques pendents)
    
    Cas base (punt clau)
    El return 0 és el que atura la recursió i permet començar a tornar enrere.
    
    Fase de pujada (executem i retornem)
    En arribar al valor 0, el programa sap que SumaRec(0) retorna 0.
    Abans d'aquest valor return 1 + SumaRec(0), es veia com 1 + ?, però després ja sap que
    SumaRec(0) = 0 i pot fer 1 + 0 = 1, i ara ja coneix quan és SumaRec(1) = 1 i així amb tots.

    Es resolen les operacions:
    SumaRec(1) = 1 + SumaRec(0) = 1 + 0 = 1
    SumaRec(2) = 2 + SumaRec(1) = 2 + 1 = 3
    SumaRec(3) = 3 + SumaRec(2) = 3 + 3 = 6 
    SumaRec(4) = 4 + SumaRec(3) = 4 + 6 = 10 
     */
    public static int SumaRec(int n)
    {
        if (n == 0) return 0; //cas base

        return n + SumaRec(n - 1); //cas recursiu
    }


    /*
     Plantilla universal per crear una funció de recursivitat
        
    - Decidir que ha de fer la funció
        - Tobar el cas base (condició per aturar les crides recursives)
        - Definir el pas actual (com es redueix el problema)
        - Cas recursiu (Cridar la funció amb el problema més petit)

    Definició de la funció (public (modificador d'accés) i static (mètode pertany a la classe) no son obligatoris)
    public static returnType functionNom (params){
        
        if(casBase) return valorBase;
        
        return pasActual + funtionNom(problemaMesPetit);
    }
     */


    /*
     Fase de baixada (crides) amb CountdownEvent(3):
        CountdownEvent(3)
        CountdownEvent(2)
        CountdownEvent(1)
        CountdownEvent(0) <- cas base

     Fase de pujada (executem i retornem)
        CountdownEvent(0) = retorna i no fa res
        CountdownEvent(1) = imprimeix 1 i retorna
        CountdownEvent(2) = imprimeix 2 i retorna
        CountdownEvent(3) = imprimeix 3 i retorna
     */
    public static void CountdownEvent(int n)
    {
        if (n == 0) return; //cas base

        /*Tot el que està abans de la crida recursiva passa a la baixada
          Tot el que està després de la crida passa a la pujada*/

        Console.WriteLine("..."); //fase de baixada
        CountdownEvent(n - 1); //cas recursiu
        Console.WriteLine(n); //fase de pujada

    }

    /*
        Fase de baixada (crides) amb CountDigits(4321):
        
        CountDigits(4321) = 1 + CountDigits(432)
        CountDigits(432) = 1 + CountDigits(43)
        CountDigits(43) = 1 + CountDigits(4)
        CountDigits(4) = 1   <- cas base

        Fase de pujada (executem i retornem)

        CountDigits(4) = 1
        CountDigits(43) = 1 + CountDigits(4) = 1 + 1 = 2
        CountDigits(432) = 1 + CountDigits(43) = 1 + 2 = 3
        CountDigits(4321) = 1 + CountDigits(432) = 1 + 3 = 4
     */

    public static int CountDigits(int n)
    {
        //Si només queda un dígit (0 al 9), ja no cal seguir.
        if (n < 10) return 1; //cas base

        //(n / 10) elimina l'últim dígit de n.
        return 1 + CountDigits(n / 10); //cas recursiu
    }



}