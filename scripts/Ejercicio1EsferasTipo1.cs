using UnityEngine;

public class Ejercicio1EsferasTipo1 : MonoBehaviour
{
    public GameObject esferaAPerseguir;
    public Ejercicio1Notificador notificador;
    private bool comenzarAPerseguir;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.AlertaColision += PersigueEsfera;
        comenzarAPerseguir = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (comenzarAPerseguir)
        {
            Vector3 distanciaAEsfera = (esferaAPerseguir.transform.position - transform.position).normalized;
            transform.Translate(distanciaAEsfera * Time.deltaTime);            
        }
    }
    // Pertigue a la esferaAPerseguir
    void PersigueEsfera()
    {
        comenzarAPerseguir = true;
    }
}
