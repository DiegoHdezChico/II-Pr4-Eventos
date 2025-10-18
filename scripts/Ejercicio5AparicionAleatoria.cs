using UnityEngine;

public class Ejercicio5AparicionAleatoria : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float posicionX = Random.Range(5, 45);
        float posicionZ = Random.Range(5, 45);
        gameObject.transform.position = new Vector3(posicionX, 2, posicionZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
