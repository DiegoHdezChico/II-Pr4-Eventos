using UnityEngine;
using UnityEngine.UI;

public class Ejercicio7ControladorRecompensa : MonoBehaviour
{
    public Ejercicio3Notificador notificador;
    private Image imagen;
    private float contadorPuntuacion;
    private float contadorFrames;
    
    void AumentarContador(string tagEscudoRecolectado)
    {
        if (tagEscudoRecolectado == "escudo_tipo1")
        {
            contadorPuntuacion += 5;
        }
        if (tagEscudoRecolectado == "escudo_tipo2")
        {
            contadorPuntuacion += 10;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.AlertaColision += AumentarContador;
        imagen = gameObject.GetComponent<Image>();
        imagen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (imagen.enabled)
        {
            ++contadorFrames;
        }
        if (imagen.enabled && contadorFrames == 240)
        {
            imagen.enabled = false;
            contadorFrames = 0;
        }
        if (contadorPuntuacion >= 100)
        {
            imagen.enabled = true;
            contadorPuntuacion -= 100;
        }
    }
}
