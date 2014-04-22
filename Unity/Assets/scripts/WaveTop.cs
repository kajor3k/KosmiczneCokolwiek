using UnityEngine;
using System.Collections;

public class WaveTop: MonoBehaviour {
	float timer = 0.0f;
	int EnemyAmount=0;


	public Transform EnemySpawnerTop;


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
		EnemySpawnTop();

			
		if (timer >= 5.0f)
		{
			while(EnemyAmount!=0){
				EnemySpawnTop();
				EnemyAmount--;
				
			}

			EnemyAmount++;
			timer = 0.0f;
		}
		timer += Time.deltaTime;
	
	}
}
