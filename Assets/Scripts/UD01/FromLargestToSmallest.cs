using UnityEngine;

/*
 * Introduce 3 n�meros que aparezcan en pantalla de mayor a
menor. Nombra al �script� �FromLargestToSmallest�
 */
public class FromLargestToSmallest : MonoBehaviour
{

    public int NumberA = 0;
    public int NumberB = 1;
    public int NumberC = 2;
    public int Temp = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OrderFromLargestToSmallest();
    }

    public void OrderFromLargestToSmallest()
    {

        if (NumberA < NumberB) { Temp = NumberA; NumberA = NumberB; NumberB = Temp; }
        if (NumberB < NumberC) { Temp = NumberB; NumberB = NumberC; NumberC = Temp; }
        if (NumberA < NumberB) { Temp = NumberA; NumberA = NumberB; NumberB = Temp; }

        Debug.Log("De mayor a menor:\n" + NumberA + ">" + NumberB + ">" + NumberC);
    }
}
