using UnityEngine;

public class MultiplesOfThree : MonoBehaviour
{

    private int _numbers = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowMultiples();
    }

    public void ShowMultiples()
    {
        if (_numbers != 0)
        {
            if (_numbers % 3 == 0)
            {
                Debug.Log("Múltiplo de 3: " + _numbers);
            }
            _numbers--;
            ShowMultiples();
        }
    }
}
