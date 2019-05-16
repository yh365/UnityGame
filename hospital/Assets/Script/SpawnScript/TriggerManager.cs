using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text;
using System.IO;
using System;


public class TriggerManager : MonoBehaviour
{
	string fileName = "logfile.txt";
	public int[] sum = new int[27];
	public int[] cntArr = new int[27];
	public int[] sortedIndex = new int[27];
	public string cnt = "";
	public GameObject obj;
	public GameOverMenu gom;
    SpawnManager sm;
	bool chkSort = false;
	// Use this for initialization
	void Start () {
		gom = GameObject.Find("FirstPersonCharacter").GetComponent<GameOverMenu>();
		loadFile();
		for (int i = 0; i < sum.Length; i++)
		{
			sortedIndex[i] = i;
		}
		sortArray();
		loadFile();

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerExit(Collider other)
	{

		if (other.transform.tag == "sensor")
		{
			cnt = "";
			cntArr[obj.transform.Find(other.name).GetSiblingIndex()]++;

			for (int i = 0; i < cntArr.Length-1; i++)
				cnt = cnt + cntArr[i].ToString()+",";
			cnt = cnt + cntArr[26];
			Debug.Log(cnt);
			gom.cnt = cnt;
		}

	}
	void loadFile()
	{
		if (File.Exists(fileName))
		{
			FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			StreamReader sr = new StreamReader(fs, Encoding.UTF8);

			string lineVal = null;
			string[] val = null;
			int count = 0;

			while ((lineVal = sr.ReadLine()) != null)
			{
				val = lineVal.Split(',');

				for (int i = 0; i < val.Length; i++)
				{
					int n = 0;
					if (int.TryParse(val[i], out n))
						sum[i] = sum[i] + n;
				}
				count++;
			}
			sr.Close();
			fs.Close();
		}
		else
		{
			Debug.Log("파일이 없습니다.");
		}

	}
	void sortArray()
	{
		if (!chkSort)
		{
			int min = 0;
			int temp = 0;
			for (int i = 0; i < sum.Length; i++)
			{
				min = i;
				for (int j = i + 1; j < sum.Length; j++)
				{
					if (sum[min] > sum[j])
					{
						min = j;
					}
				}
				temp = sortedIndex[i];
				sortedIndex[i] = sortedIndex[min];
				sortedIndex[min] = temp;
				temp = sum[i];
				sum[i] = sum[min];
				sum[min] = temp;
			}
			cnt = "";
			chkSort = true;
		}

	}

}