using UnityEngine;

/*
 * 2. Introduce 3 números que aparezcan en pantalla de menor a
mayor. Nombra al “script” “FromSmallestToLargest”.
 */

public class FromSmallestToLargest : MonoBehaviour

{

    public int NumberA = 0;
    public int NumberB = 1;
    public int NumberC = 2;
    public int Temp = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OrderFromSmallestToLargest();
    }

    public void OrderFromSmallestToLargest()
    {

        if (NumberA > NumberB) { Temp = NumberA; NumberA = NumberB; NumberB = Temp; }
        if (NumberB > NumberC) { Temp = NumberB; NumberB = NumberC; NumberC = Temp; }
        if (NumberA > NumberB) { Temp = NumberA; NumberA = NumberB; NumberB = Temp; }

        Debug.Log("De menor a mayor:\n" + NumberA + "<" + NumberB + "<" + NumberC);
    }
}
