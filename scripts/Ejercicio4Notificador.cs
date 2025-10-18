using UnityEngine;

public class Ejercicio4Notificador : MonoBehaviour
{
    public delegate void mensaje();
    public event mensaje AlertaColision;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "objeto_referencia")
        {
            AlertaColision();
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
