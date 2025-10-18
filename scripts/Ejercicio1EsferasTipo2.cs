using UnityEngine;
using UnityEngine.Playables;

public class Ejercicio1EsferasTipo2 : MonoBehaviour
{
    public Ejercicio1Notificador notificador;
    private GameObject cilindroAPerseguir;
    private bool perseguirACilindro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cilindroAPerseguir = GameObject.FindGameObjectWithTag("cilindro");
        perseguirACilindro = false;
        notificador.AlertaColision += PersigueCilindro;
    }

    // Update is called once per frame
    void Update()
    {
        if (perseguirACilindro)
        {
            Vector3 distancia = (cilindroAPerseguir.transform.position - transform.position).normalized;
            transform.position += distancia * Time.deltaTime;
        }
    }
    void PersigueCilindro()
    {
        perseguirACilindro = true;
    }
}
