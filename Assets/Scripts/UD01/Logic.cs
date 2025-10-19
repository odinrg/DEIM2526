using UnityEngine;

public class Logic : MonoBehaviour
{

    private bool[] _arrayOne = new bool[3] {false, false, false};

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        validateFirstItem(_arrayOne);
    }

    public void validateFirstItem(bool[] arrayOne)
    {
        arrayOne[0] = true;
        Debug.Log("Primer valor: " + arrayOne[0]);
        Debug.Log("Segundo valor: " + arrayOne[1]);
        Debug.Log("Tercer valor: " + arrayOne[2]);
    }
}
