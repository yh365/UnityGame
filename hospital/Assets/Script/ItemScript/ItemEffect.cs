using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemEffect : MonoBehaviour {

	public GameObject cube;
	public GameObject explosion;

	void OnTriggerEnter(Collider other)
	{
		Destroy(cube);
		Instantiate(explosion, transform.position, transform.rotation);
		ItemSound.instance.PlaySound();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
