using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
namespace UnityStandardAssets.Characters.ThirdPerson
{
	[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
	[RequireComponent(typeof(ThirdPersonCharacter))]
	public class EnemyAI : MonoBehaviour
	{
		NavMeshAgent Navi;
		public UnityEngine.AI.NavMeshAgent agent { get; private set; } // the navmesh agent required for the path finding
		public ThirdPersonCharacter character { get; private set; } // the character we are controlling
		public GameObject player;
		public GameObject triggerObj;
		public float moveSpeed = 3f;
		TriggerManager tm;
		int i = 0;
		// Use this for initialization
		void Start()
		{
			tm = GameObject.Find("triggerObject").GetComponent<TriggerManager>();
			Navi = GetComponent<NavMeshAgent>();
			agent = GetComponentInChildren<UnityEngine.AI.NavMeshAgent>();
			character = GetComponent<ThirdPersonCharacter>();
		}

		// Update is called once per frame
		void Update()
		{
			RaycastHit hit;
			if (Vector3.Distance(this.transform.position,player.transform.position) < 10) 
			{
				moveSpeed = 2f;
				Debug.Log ("find");
				Navi.SetDestination (player.transform.position);
				character.Move (agent.desiredVelocity, false, false);
			} 
			else
			{
				findPlayer ();
			}

		
		}
		void findPlayer()
		{
			int index = tm.sortedIndex[i];
			Vector3 pos = triggerObj.transform.GetChild(index).position;
			float distance = Vector3.Distance(this.transform.position, pos);
			Navi.speed = moveSpeed;
			Navi.SetDestination(pos);
			character.Move(agent.desiredVelocity, false, false);

			Debug.Log(pos);
			Debug.Log(i);
			Debug.Log(distance);
			if (distance < 4)
			{
				i++;
				if (i > 26)
					i = 0;
			}
		}
	}
}