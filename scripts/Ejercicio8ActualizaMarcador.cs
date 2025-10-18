using TMPro;
using UnityEngine;

public class Ejercicio8ActualizaMarcador : MonoBehaviour
{
    private TextMeshProUGUI texto;
    private float valorMarcador;
    public Ejercicio3Notificador notificador;
    void ActualizaTexto(string tagColision)
    {
        if (tagColision == "escudo_tipo1")
        {
            valorMarcador += 5;
        }
        if (tagColision == "escudo_tipo2")
        {
            valorMarcador += 10;
        }
        if (tagColision == "enemigo")
        {
            valorMarcador -= 10;
        }
        texto.text = valorMarcador.ToString();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        notificador.AlertaColision += ActualizaTexto;
        texto = gameObject.GetComponent<TextMeshProUGUI>();
        valorMarcador = 0;
        texto.text = valorMarcador.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
