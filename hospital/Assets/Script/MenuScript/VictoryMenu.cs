using System.Collections;
using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using UnityEngine;

public class VictoryMenu : MonoBehaviour {
	public GameObject VictoryUI;
	public string cnt;
	public int eCnt;
	string fileName = "logfile.txt";
	public bool chk = false;

	bool saveChk = false;
	// Use this for initialization
	void Start () {
		VictoryUI.SetActive(false);
		saveChk = false;
	}

	// Update is called once per frame
	void Update ()
	{
		
		if (GameObject.FindGameObjectsWithTag ("enemy").Length == 3)
		{
			VictoryUI.SetActive(true);
			// Mouse Lock

			Cursor.lockState = CursorLockMode.None;

			// Cursor visible

			Cursor.visible = true;
			if(!saveChk)
				saveFile();
		}
		else
		{
			VictoryUI.SetActive(false);
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