using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	public bool enableSpawn = true;
	public GameObject item; //Prefab을 받을 public 변수 입니다.
	public GameObject triggerObj;
	public GameObject enemyObj;
	public TriggerManager tm;
	public TimerManager timeManager;
	public int cnt;
	bool itemChk = true;
	GameObject itemObj = null;

	void Start () {
		tm = GameObject.Find("triggerObject").GetComponent<TriggerManager>();
		timeManager = GameObject.Find("Time").GetComponent<TimerManager> ();
		cnt = PNum.PlayerNum;
		itemObj = spawnItem(item);
		spawnEnemy(cnt);

		//InvokeRepeating("SpawnEnemy", 1, 3); //3초후 부터, SpawnEnemy함수를 1초마다 반복해서 실행 시킵니다.
		//CancelInvoke("호출할 함수명");
	}
	void Update () {
		if(timeManager.min < 1 && itemChk)
		{
			int randomIndex = Random.Range (15, 25);
			Vector3 pos = triggerObj.transform.GetChild (randomIndex).position;
			pos.y = 0.7f;
			itemObj.transform.position = pos;
			Debug.Log ("아이템 이동됨");
			itemChk = false;
		}
	}
	public GameObject spawnItem(GameObject item)
	{
		GameObject obj = null;

		Vector3 pos1 = new Vector3 (7f, 1.5f, 10f);
		obj = Instantiate (item, pos1, Quaternion.identity); // 랜덤한 위치와, 화면 제일 위에서 아이템 생성

		return obj;
	}

	public void spawnEnemy(int count)
	{
		int rand = Random.Range(0, 2);
		for (int i = 0; i < count; i++)
		{
			int randomIndex = Random.Range(0, 2);
			int index = tm.sortedIndex[i + rand*count];
			GameObject enemy = enemyObj.transform.GetChild(randomIndex).gameObject;
			Vector3 pos = triggerObj.transform.GetChild(index).position;
			Quaternion rotation = enemyObj.transform.GetChild(randomIndex).rotation;
			Instantiate(enemy, pos, rotation);
			Debug.Log(i + "번 오브젝트 생성 위치 : " + index);
		}
	}

}