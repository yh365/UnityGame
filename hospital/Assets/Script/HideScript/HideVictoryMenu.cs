using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideVictoryMenu : MonoBehaviour {
	public GameObject VictoryUI;
	public HideTimerManager time;

	// Use this for initialization
	void Start () {
		VictoryUI.SetActive(false);
	
	}

	// Update is called once per frame
	void Update ()
	{

		if (!time.chkState)
		{
			VictoryUI.SetActive(true);
			// Mouse Lock

			Cursor.lockState = CursorLockMode.None;

			// Cursor visible

			Cursor.visible = true;
		
		}
		else
		{
			VictoryUI.SetActive(false);
			//Cursor.visible = false;
		}
	}
}
