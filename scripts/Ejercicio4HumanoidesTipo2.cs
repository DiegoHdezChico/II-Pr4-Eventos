using UnityEngine;

public class Ejercicio4HumanoidesTipo2 : MonoBehaviour
{
    public Ejercicio4Notificador notificador;
    void MiraObjeto()
    {
        GameObject cuboAMirar = GameObject.FindGameObjectWithTag("cubo_a_mirar");
        gameObject.transform.LookAt(cuboAMirar.transform);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.AlertaColision += MiraObjeto;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
