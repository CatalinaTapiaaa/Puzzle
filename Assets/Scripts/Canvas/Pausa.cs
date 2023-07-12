using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
	public GameObject panelPausa;
    public GameObject panelInterface;

    public Animator ani;

    [Space]
    public GameObject componente;
    public UI ui;

    private void Start()
    {
        componente = GameObject.Find("--------------UI");
        ui = componente.GetComponent<UI>();
    }

    public void Pausar()
	{
		panelPausa.SetActive(true);
        panelInterface.SetActive(false);
        Time.timeScale = 0;
	}
	public void Reanudar()
	{
        StartCoroutine(AnimacionReanudar());
    }
    public void Reiniciar()
    {
        ui.Gameplay();
    }
    public void Menu()
    {
        ui.Menu();
    }



    private IEnumerator AnimacionReanudar()
    {
        panelPausa.SetActive(false);
        panelInterface.SetActive(true);
        ani.SetBool("Activar", true);
        yield return new WaitForSeconds(3);
        ani.SetBool("Activar", false);
        Time.timeScale = 1;       
    }
}
