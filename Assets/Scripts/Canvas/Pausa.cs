using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
	public GameObject panel;

	public void Pausar()
	{
		panel.SetActive(true);
		Time.timeScale = 0;
	}
	public void Reanudar()
	{
		panel.SetActive(false);
		Time.timeScale = 1;
	}
}
