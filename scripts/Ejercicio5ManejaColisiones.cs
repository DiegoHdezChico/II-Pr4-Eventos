using UnityEngine;

public class Ejercicio5ManejaColisiones : MonoBehaviour
{
    private float contador;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "escudo_tipo1")
        {
            contador += 5;
        }
        if (collision.gameObject.tag == "escudo_tipo2")
        {
            contador += 10;
        }
        collision.gameObject.SetActive(false);
        Debug.Log("El contador vale " + contador);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        contador = 0;
        Debug.Log("El contador vale " + contador);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
