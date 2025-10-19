using UnityEngine;

/*
 * Muestra los números pares entre el 0 y el 100. Nombra al
“script” “Even”.
*/

public class Even : MonoBehaviour
{

    private int _numbers = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowEven();
    }

    public void ShowEven()
    {
        if (_numbers != 0)
        {
            if (_numbers % 2 == 0)
            {
                Debug.Log("Número par: " + _numbers);
            }
            _numbers--;
            ShowEven();
        }
    }
}
