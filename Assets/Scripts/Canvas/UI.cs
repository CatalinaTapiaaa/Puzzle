using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Animator ani;
	public float tiempoAni;

	private int scena;
	private static bool created;

	public void Start()
	{
		ani = GetComponent<Animator>();

		if (created)
		{
			Destroy(gameObject);
			return;
		}

		DontDestroyOnLoad(gameObject);
		created = true;
	}

	public void Menu()
	{
		StartCoroutine(Animacion());
		Time.timeScale = 1;
		scena = 1;
	}
	public void Gameplay()
	{
		StartCoroutine(Animacion());
		Time.timeScale = 1;
		scena = 3;
	}
	public void Creditos()
	{
		StartCoroutine(Animacion());
		Time.timeScale = 1;
		scena = 4;
	}


	private IEnumerator Animacion()
	{
		ani.SetBool("On", true);
		ani.SetBool("Off", false);
		yield return new WaitForSeconds(tiempoAni);
		SceneManager.LoadScene(scena);
		ani.SetBool("On", false);
		ani.SetBool("Off", true);
	}
}
