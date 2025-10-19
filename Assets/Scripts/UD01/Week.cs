using UnityEngine;
/*
 * Introduce un número del 1 al 7 y di el nombre del mes
correspondiente. Nombra al “script” “Week”
*/

public class Week : MonoBehaviour
{
    //Variables globales
    public int WeekDay = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetWeekDay();
    }

    //Imprimir el día de la semana
    public void GetWeekDay()
    {

        switch(WeekDay)
        {
            case 0:
                Debug.Log("Introduce un valor valido");
                break;
            case 1:
                Debug.Log("Lunes");
                break;
            case 2:
                Debug.Log("Martes");
                break;
            case 3:
                Debug.Log("Miércoles");
                break;
            case 4:
                Debug.Log("Jueves");
                break;
            case 5:
                Debug.Log("Viernes");
                break;
            case 6:
                Debug.Log("Sábado");
                break;
            case 7:
                Debug.Log("Domingo");
                break;
        }
    }
}
