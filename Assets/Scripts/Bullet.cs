using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float lifeTime;
    public Scores scores;
    public int whichBullet;
    public AudioSource bubbleSound;
    public AudioSource moneySound;
    private void Start()
    {
        lifeTime = 7.0f;
        scores = GameObject.FindGameObjectWithTag("Scores").GetComponent<Scores>();
        bubbleSound = GameObject.FindGameObjectWithTag("BubbleSound").GetComponent<AudioSource>();
        moneySound = GameObject.FindGameObjectWithTag("MoneySound").GetComponent<AudioSource>();
    }
    private void Update()
    {
        this.transform.Translate(Vector3.up / 1.5f);
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bubble1")
        {
            bubbleSound.Play();
            if (whichBullet == 1)
            {
                moneySound.Play();
                Destroy(collision.gameObject);
                scores.scoresCounter += 20;
            }
            if (whichBullet == 0)
            {
                moneySound.Play();
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                scores.scoresCounter += 20;
            }
            if (whichBullet == 2)
            {
                collision.GetComponent<Bubble>().canSLow = true;
            }
        }
        if (collision.tag == "Bubble2")
        {
            bubbleSound.Play();
            if (whichBullet == 1)
            {
                moneySound.Play();
                Destroy(collision.gameObject);
                scores.scoresCounter += 20;
            }
            if (whichBullet == 0)
            {
                moneySound.Play();
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                scores.scoresCounter += 20;
            }
            if (whichBullet == 2)
            {
                collision.GetComponent<Bubble>().canSLow = true;
            }
        }
    }
}
