using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour {

	public GameObject StartUI;

	// Use this for initialization
	void Start () {
		StartUI.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OpenStart()
	{
		OnMouseSound.instance.PlaySound ();
		StartUI.SetActive(true);
	}

	public void Quit()
	{
		OnMouseSound.instance.PlaySound ();
		StartUI.SetActive(false);
	}
}
