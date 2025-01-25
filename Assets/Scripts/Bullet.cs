using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float lifeTime;
    public Scores scores;
    private void Start()
    {
        lifeTime = 7.0f;
        scores = GameObject.FindGameObjectWithTag("Scores").GetComponent<Scores>();
    }
    private void Update()
    {
        this.transform.Translate(Vector3.up / 1.5f);
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bubble")
        {
            scores.scoresCounter += 20;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
