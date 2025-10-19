using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    private int _randomNumber = Random.Range(0, 4);
    private string[] _arrayOne = new string[5] {
        "Pronto descubrirás un talento oculto para la música.",
        "Un encuentro inesperado te traerá una gran alegría.",
        "Hoy es el día perfecto para iniciar un proyecto creativo.",
        "Tu paciencia será recompensada con una sorpresa positiva.",
        "Alguien cercano te revelará un secreto importante."
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ShowRandomNumber(_randomNumber);
    }

    // Update is called once per frame
    public void ShowRandomNumber(int number)
    {
        Debug.Log(_arrayOne[number]);
    }
}
