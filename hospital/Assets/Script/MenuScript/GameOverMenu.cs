using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using UnityEngine;

public class GameOverMenu : MonoBehaviour {
	public TimerManager time;
	public GameObject GameOverUI;
	public string cnt;
	string fileName = "logfile.txt";
	private bool paused = false;

	bool saveChk = false;
	// Use this for initialization
	void Start () {
		GameOverUI.SetActive(false);
		saveChk = false;
	}

	// Update is called once per frame
	void Update ()
	{
		if (!time.chkState)
		{
			GameOverUI.SetActive(true);
			// Mouse Lock

			Cursor.lockState = CursorLockMode.None;

			// Cursor visible

			Cursor.visible = true;
			if(!saveChk)
				saveFile();
		}
		else
		{
			GameOverUI.SetActive(false);
			//Cursor.visible = false;
		}
	}

	public void saveFile()
	{
		Debug.Log("저장될로그 : " + cnt);
		if (File.Exists(fileName))
		{
			FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write);
			StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
			sw.WriteLine(cnt);
			sw.Close();
			fs.Close();
			saveChk = true;
		}
	}
}