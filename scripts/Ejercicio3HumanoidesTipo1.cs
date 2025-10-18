using UnityEngine;

public class Ejercicio3HumanoidesTipo1 : MonoBehaviour
{
    public Ejercicio3NotificadorTrigger notificador;
    public GameObject escudoSeleccionado;
    private bool activarMovimientoAEscudoSeleccionado;
    private bool activarMovimientoAEscudosTipo2;
    private float velocidad;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void ReaccionColision(string tagColision)
    {
        if (tagColision == "humanoide_tipo2")
        {
            activarMovimientoAEscudoSeleccionado = true;
            activarMovimientoAEscudosTipo2 = false;
        }
        if (tagColision == "humanoide_tipo1")
        {
            activarMovimientoAEscudoSeleccionado = false;
            activarMovimientoAEscudosTipo2 = true;
        }
    }
    void MovimientoAEscudoSeleccionado()
    {
        Vector3 distancia = (escudoSeleccionado.transform.position - transform.position).normalized;
        Vector3 eliminaAltura = new Vector3(0, distancia.y, 0);
        distancia = (distancia - eliminaAltura).normalized;
        transform.Translate(distancia * Time.deltaTime * velocidad);
    }

    void MovimientoAEscudosTipo2()
    {
        GameObject contenedorEscudos2 = GameObject.FindGameObjectWithTag("contenedor_tipo2");
        Vector3 distancia = (contenedorEscudos2.transform.position - transform.position).normalized;
        transform.Translate(distancia * Time.deltaTime * velocidad);
    }
    void Start()
    {
        notificador.AlertaTrigger += ReaccionColision;
        activarMovimientoAEscudoSeleccionado = false;
        activarMovimientoAEscudosTipo2 = false;
        velocidad = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        if (activarMovimientoAEscudoSeleccionado)
        {
            MovimientoAEscudoSeleccionado();
        }
        if (activarMovimientoAEscudosTipo2)
        {
            MovimientoAEscudosTipo2();
        }        
    }
}
