using UnityEngine;

public class Ejercicio3Controlador : MonoBehaviour
{
    private float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        velocidad = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * velocidad * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * velocidad * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime, Space.World);
        }        
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime, Space.World);
        }
    }
}
