using UnityEngine;
using System.Collections;

public class WaveTop: MonoBehaviour {
	float timer = 0.0f;
	int EnemyAmount=0;
	float reloadingTime = 1f;
	bool canShoot = true;

	public Transform EnemySpawnerTop;


	public GameObject EnemyMissile;
	// Use this for initialization
	void Start () {


	
	}
	IEnumerator Reload(float time)
	{
		yield return new WaitForSeconds(time);
		canShoot = true;
	}

	void EnemySpawnTop()
	{
				GameObject.Instantiate (EnemyMissile, EnemySpawnerTop.position, EnemySpawnerTop.rotation);
		canShoot = false;
			StartCoroutine(Reload(reloadingTime));
	}
	
	// Update is called once per frame
	void Update () {


			
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
