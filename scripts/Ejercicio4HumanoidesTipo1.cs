using UnityEngine;

public class Ejercicio4HumanoidesTipo1 : MonoBehaviour
{
    public Ejercicio4Notificador notificador;
    private GameObject objetivo;
    void Teletransporte()
    {
        transform.position = new Vector3(objetivo.transform.position.x, transform.position.y, objetivo.transform.position.z);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.AlertaColision += Teletransporte;
        objetivo = GameObject.FindGameObjectWithTag("escudo_tipo1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
