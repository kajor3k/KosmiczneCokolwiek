using UnityEngine;
using System.Collections;

public class PlayerControler : MonoBehaviour {
    public GameObject missile;
   

    public Transform misslespawnerW;
    public Transform misslespawnerA;
    public Transform misslespawnerS;
    public Transform misslespawnerD;

    int hp;

   // bool W = Input.GetKeyDown(KeyCode.W);
    //bool A = Input.GetKeyDown(KeyCode.A);
   // bool S = Input.GetKeyUp(KeyCode.S);
   // bool D = Input.GetKeyUp(KeyCode.D);

    bool canShoot = true;
    float reloadingTime = 1f; //to będzie 1 sekunda
    int count;
    float timer = 0.0f;
 
	// Use this for initialization
	void Start () {
        hp = 3;
        count = 5;
	}


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Missile")
        {
            hp -= 1;
            Debug.Log("Baza jest smutna. Zostalo HP: " + hp);
            if (hp <= 0)
                Destroy(gameObject);
        }
    }

    IEnumerator Reload(float time)
    {
        yield return new WaitForSeconds(time);
        canShoot = true;
    }

    void ShootW()
    {
        GameObject.Instantiate(missile, misslespawnerW.position, misslespawnerW.rotation);
        canShoot = false;
        StartCoroutine(Reload(reloadingTime));
    }

    void ShootA()
    {
        GameObject.Instantiate(missile, misslespawnerA.position, misslespawnerA.rotation);
        canShoot = false;
        StartCoroutine(Reload(reloadingTime));
    }

    void ShootS()
    {
        GameObject.Instantiate(missile, misslespawnerS.position, misslespawnerS.rotation);
        canShoot = false;
        StartCoroutine(Reload(reloadingTime));
    }

    void ShootD()
    {
        GameObject.Instantiate(missile, misslespawnerD.position, misslespawnerD.rotation);
        canShoot = false;
        StartCoroutine(Reload(reloadingTime));
    }
    void OnGUI()
    {
        GUI.Label(new Rect(10, 30, 250, 20), "ILOSC JEDNOSTEK: " + count);

    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.W) && canShoot && count!=0)
        {
            ShootW(); Debug.Log("SHOT W");
            count--;
        }
        if (Input.GetKey(KeyCode.A) && canShoot && count != 0)
        {
            ShootA();
            count--;
        }
        if (Input.GetKey(KeyCode.S) && canShoot && count != 0)
        {
            ShootS();
            count--;
        }
        if (Input.GetKey(KeyCode.D) && canShoot && count != 0)
        { 
            ShootD();
            count--;
        }
        if (timer >= 5.0f)
        {
            count++;
            timer = 0.0f;
        }
        timer += Time.deltaTime;


       // Debug.Log(timer % -5.0f);
       // Debug.Log("count = "+count);
	}
}
