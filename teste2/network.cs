namespace teste2        
public class Network
{
    private int numElemets;

    public void Elementos (int numElements)
    {
        this.numElemets = numElements;

        Console.Write(numElements);

        if (numElements < 0)
        throw new Exception(" O número de elementos deve ser inteiro positivo")
    }


}