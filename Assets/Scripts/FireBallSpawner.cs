using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallSpawner : MonoBehaviour {

	public GameObject m_Prefab;
	public System.Random m_SpawnDelay;
	public float time;
	public float currentTime;
	private float m_spawnTimer;
	public float extraDelay = 0;
	public int upper =5;
	public int lower =2;

	private void Awake()
	{
		m_SpawnDelay = new System.Random();
		time = m_SpawnDelay.Next (lower, upper);
		currentTime = time;
	}


	private void FixedUpdate(){

		currentTime -= Time.deltaTime;
		if (currentTime+extraDelay <= 0) {
			Instantiate (m_Prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), transform.rotation);
			time = m_SpawnDelay.Next (lower, upper);
			currentTime = time;

		}

	}

}
