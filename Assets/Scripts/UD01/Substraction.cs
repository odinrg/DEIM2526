using UnityEngine;

public class Substraction : MonoBehaviour
{

    public int Number = 0;
    int _resultado = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowSubstraction();
    }

    public void ShowSubstraction()
    {
        _resultado = 1;  // Comenzamos desde 1

        for (int i = 2; i <= Number; i++)
        {
            _resultado = _resultado - i;
        }
        Debug.Log("La resta de los números del 1 al " + Number + " es: " + _resultado);
    }
}
