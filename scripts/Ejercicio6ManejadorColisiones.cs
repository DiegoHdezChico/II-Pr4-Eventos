using UnityEngine;
public class Ejercicio6ManejadorColisiones : MonoBehaviour
{
    private float contador;
    private bool activo;
    private Rigidbody rb;
    private BoxCollider bc;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            activo = false;
            rb.isKinematic = true;
            bc.isTrigger = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        bc = gameObject.GetComponent<BoxCollider>();
        contador = 0;
        activo = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!activo)
        {
            ++contador;
        }
        if (contador == 600)
        {
            contador = 0;
            rb.isKinematic = false;
            bc.isTrigger = false;
            activo = true;
        }
    }
}
