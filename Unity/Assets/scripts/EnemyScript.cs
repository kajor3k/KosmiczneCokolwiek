using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{

    public float speed = 0.1f;
    // Use this for initialization
    void Start()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
}