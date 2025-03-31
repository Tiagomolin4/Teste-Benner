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
    public void connect(int elemento1, int elemento2)
    {

    }

    public void disconnect(int elemento1, int elemento2)
    {

    }

    public bool query(int elemento1, int elemento2)
    {

    }

    public int levelConnection(int elemento1, int elemento2)
    {

    }

}
