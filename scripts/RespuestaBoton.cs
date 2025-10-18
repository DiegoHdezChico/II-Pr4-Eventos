using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespuestaBoton : MonoBehaviour
{
    Renderer rd;
    // Start is called before the first frame update
    void Start()
    {
        rd = this.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void respuestaclick()
    {
        rd.material.color = Color.green;
    }
}
