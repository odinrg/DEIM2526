using UnityEngine;

public class Change : MonoBehaviour
{

    private int[] _arrayOne = new int[5] { 1, 1, 1, 1, 1 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Número de elementos en el array: " +  _arrayOne.Length);
        changePosition(_arrayOne);
    }

   public void changePosition(int[] array)
    {
        _arrayOne[0] = 42;
        _arrayOne[4] = 42;
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(_arrayOne[i]);
        }
    }
}
