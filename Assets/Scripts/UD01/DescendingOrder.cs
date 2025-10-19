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
            Debug.Log("Los números están en orden decreciente.\n");
        }
        else
        {
            Debug.Log("Los números NO están en orden decreciente.\n");
        }
    }
}
