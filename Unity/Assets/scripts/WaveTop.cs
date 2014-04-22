using UnityEngine;
using System.Collections;

public class Wave : MonoBehaviour {
	float timer = 0.0f;
	int EnemyAmount=0;
	float reloadingTime = 1f;
	bool canShoot = true;

	public Transform EnemySpawnerTop;


	public GameObject EnemyMissile;
	// Use this for initialization
	void Start () {


	
	}

	void EnemySpawnTop()
	{
				GameObject.Instantiate (EnemyMissile, EnemySpawnerTop.position, EnemySpawnerTop.rotation);
			canShoot = false;
			StartCoroutine(Reload(reloadingTime));
	}
	
	// Update is called once per frame
	void Update () {


			
		if (timer >= 20.0f)
		{
			if(EnemyAmount!=0)
			{
				EnemySpawnTop();
				count--;

			}

			EnemyAmount++;
			timer = 0.0f;
		}
		timer += Time.deltaTime;
	
	}
}
