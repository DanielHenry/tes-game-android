using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class utama : MonoBehaviour {

	private GameObject after_button_text;

	// Use this for initialization
	void Start () {
		after_button_text = this.gameObject.transform.GetChild(1).gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			SceneManager.LoadScene("exit_confirmation");
		}
	}

	public void tombolSatu()
	{
		after_button_text.GetComponent<Text>().text = "satu";
	}
	public void tombolDua()
	{
		after_button_text.GetComponent<Text>().text = "dua";
	}
	public void tombolTiga()
	{
		after_button_text.GetComponent<Text>().text = "tiga";
	}
	public void tombolEmpat()
	{
		after_button_text.GetComponent<Text>().text = "empat";
	}
}
