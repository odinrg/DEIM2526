using UnityEngine;

public class Number : MonoBehaviour
{

    public int UserNumber = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("N�mero incrementado en 1 unidad: " + Incrementar(UserNumber));
    }

    public int Incrementar(int num)
    {
        return num + 1;
    }
}
