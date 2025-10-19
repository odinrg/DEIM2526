using UnityEngine;

public class RandomNumber : MonoBehaviour
{

    private int _randomNumber = Random.Range(0, 4);
    private string[] _arrayOne = new string[5] {
        "Pronto descubrir�s un talento oculto para la m�sica.",
        "Un encuentro inesperado te traer� una gran alegr�a.",
        "Hoy es el d�a perfecto para iniciar un proyecto creativo.",
        "Tu paciencia ser� recompensada con una sorpresa positiva.",
        "Alguien cercano te revelar� un secreto importante."
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
