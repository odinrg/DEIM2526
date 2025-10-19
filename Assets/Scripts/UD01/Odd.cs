using UnityEngine;
/*
 * Muestra los números impares entre el 0 y el 100. Nombra al
“script” “Odd”.
*/

public class Odd : MonoBehaviour
{

    private int _numbers = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowOdds();
    }

    public void ShowOdds()
    {
        if (_numbers != 0)
        {
            if (_numbers % 2 != 0)
            {
                Debug.Log("Número impar: " + _numbers);
            }
            _numbers--;
            ShowOdds();
        }
    }
}
