using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryPauseMenu : MonoBehaviour {

	public GameObject PauseUI;
	public MemoryTimerManager time;
	private bool paused = false;

	// Use this for initialization
	void Start () {

		PauseUI.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Pause") && time.chkState)
		{
			paused = !paused;
		}
		if(paused)
		{
			PauseUI.SetActive(true);
			// Mouse Lock

			Cursor.lockState = CursorLockMode.None;

			// Cursor visible

			Cursor.visible = true;
			Time.timeScale = 0;
		}

		if(!paused)
		{
			PauseUI.SetActive(false);
			Time.timeScale = 1f;
			Cursor.visible = false;
		}

	}
}
