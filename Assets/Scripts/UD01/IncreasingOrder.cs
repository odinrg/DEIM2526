using UnityEngine;

/*
 * Introduce 3 números y detecta si se han introducido en orden
creciente. Nombra al “script” “IncreasingOrder”
 */
public class IncreasingOrder : MonoBehaviour
{

    public int NumberA = 0;
    public int NumberB = 1;
    public int NumberC = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowOrder();
    }

    public void ShowOrder()
    {

        if (NumberA < NumberB && NumberB < NumberC)
        {
            Debug.Log("Los números están en orden creciente.\n");
        }
        else
        {
            Debug.Log("Los números NO están en orden creciente.\n");
        }
    }
}
