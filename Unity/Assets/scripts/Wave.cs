using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {
	float timer = 0.0f;
	int EnemyAmount=0;

	public Transform EnemySpawnerTop;
	public Transform EnemySpawnerDown;
	public Transform EnemySpawnerLeft;
	public Transform EnemySpawnerRight;

	public GameObject EnemyMissile;
	// Use this for initialization
	void Start () {


	
	}

	void EnemySpawnTop()
	{
				GameObject.Instantiate (EnemyMissile, EnemySpawnerTop.position, EnemySpawnerTop.rotation);
	}
	
	// Update is called once per frame
	void Update () {


			
		if (timer >= 20.0f)
		{

			EnemyAmount++;
			timer = 0.0f;
		}
		timer += Time.deltaTime;
	
	}
}
