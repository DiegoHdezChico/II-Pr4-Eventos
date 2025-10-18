using Unity.VisualScripting.ReorderableList;
using UnityEngine;

public class Ejercicio3NotificadorTrigger : MonoBehaviour
{
    public delegate void mensaje(string tagColision);
    public event mensaje AlertaTrigger;
    void OnTriggerEnter(Collider collider)
    {
        AlertaTrigger(collider.gameObject.tag);
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
