using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour {
	public Transform Player;
	int MoveSpeed = 2;
	int MaxDist = 10;
	int MinDist = 5;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		transform.LookAt(Player);

		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;



			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{

				//add attack function
			}

		}
	}
	}

