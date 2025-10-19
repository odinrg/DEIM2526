using UnityEngine;

public class Shop : MonoBehaviour
{

    public int Brocoli = 0;
    public int Patata = 0;
    public int ProductoASumarORestar = 0;
    public bool sumar = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (sumar == true)
        {
            sumarProducto(ProductoASumarORestar);
        } else
        {
            restarProducto(ProductoASumarORestar);
        }
    }

    public void sumarProducto(int numero)
    {
        Brocoli += numero;
        Patata += numero;
        Debug.Log("Brocoli total: " + Brocoli + " Patata total: " +  Patata);
    }

    public void restarProducto(int numero)
    {
        Brocoli -= numero;
        Patata -= numero;
        Debug.Log("Brocoli total: " + Brocoli + " Patata total: " + Patata);
    }
}
