using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffect : MonoBehaviour
{
	private Camera m_Camera;
	public GameObject player;
	public GameObject target;
	public GameObject explosion;

	bool chk = false;
	float distance = 5;
	// Use this for initialization
	void Start()
	{
		m_Camera = Camera.main;
	}

	// Update is called once per frame
	void Update()
	{

	}
	private void OnMouseUp()
	{
		float distance = Vector3.Distance(player.transform.position, this.transform.position);
		if (distance < 2.5)
		{
			Destroy(target);
			Instantiate(explosion, transform.position, transform.rotation);
			DestroySound.instance.PlaySound();
			PNum.PlayerNum -= 1;
		}
		Debug.Log(distance);
	}
}