using UnityEngine;

public class Ejercicio3CambioColor : MonoBehaviour
{
    private Renderer rend;
    void OnTriggerEnter(Collider other)
    {
        rend.material.color = new Color(Random.value, Random.value, Random.value);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend = gameObject.GetComponentInChildren<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
