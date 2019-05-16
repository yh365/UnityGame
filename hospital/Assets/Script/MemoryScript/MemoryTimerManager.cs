using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MemoryTimerManager : MonoBehaviour
{
	public Text TimeCount;
	public int min;
	public float TimeCost;
	public bool chkState = true;
	// Use this for initialization
	void Start()
	{
		TimeCount = GetComponent<Text>();
		min = 0;
		TimeCost = 40;
	}

	// Update is called once per frame
	void Update()
	{
		if (chkState)
			TimeCost = TimeCost - Time.deltaTime;

		if (min == 0 && TimeCost < 0)
			chkState = false;

		else if (min > 0 && TimeCost < 0)
		{
			min = min - 1; TimeCost = 60;
		}

		int sec = (int)TimeCost;
		if (chkState)
			TimeCount.text = string.Format("남은시간 : 0{0:d}:{1:D2}", min, sec);

		else
		{
			SceneManager.LoadScene ("FindScene");
		}

	}
}
