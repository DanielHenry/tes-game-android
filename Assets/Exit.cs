using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Exit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void buttonYa()
	{
		Application.Quit();
	}
	public void buttonTidak()
	{
		SceneManager.LoadScene("utama");
	}
}
