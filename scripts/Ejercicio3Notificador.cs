using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Ejercicio3Notificador : MonoBehaviour
{
    public delegate void mensaje(string tagColision);
    public event mensaje AlertaColision;
    void OnCollisionEnter(Collision collision)
    {
        AlertaColision(collision.gameObject.tag);
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
