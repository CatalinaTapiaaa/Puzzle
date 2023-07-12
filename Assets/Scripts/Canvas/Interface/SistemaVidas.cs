using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaVidas : MonoBehaviour
{
    [Header("Temporizador")]
    public Slider slider;
    public float tiempoLimite;
    public bool empezarTiempo;

    [Header("Vidas")]
    public GameObject[] imagenVidas;
    private int vidas;

    void Start()
    {
        
    }

    void Update()
    {
        if (empezarTiempo)
        {
            tiempoLimite -= Time.deltaTime;

            if (tiempoLimite <= 0)
            {


            }
        }
    }
}
