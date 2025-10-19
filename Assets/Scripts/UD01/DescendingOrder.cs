using UnityEngine;

public class DescendingOrder : MonoBehaviour
{

    public int NumberA = 2;
    public int NumberB = 1;
    public int NumberC = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowOrder();
    }

    public void ShowOrder()
    {
        if (NumberA > NumberB && NumberB > NumberC)
        {
            Debug.Log("Los n�meros est�n en orden decreciente.\n");
        }
        else
        {
            Debug.Log("Los n�meros NO est�n en orden decreciente.\n");
        }
    }
}
