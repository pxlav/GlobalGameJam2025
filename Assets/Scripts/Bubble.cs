using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed;
    public int currentTarget;
    public List<GameObject> targets;
    public int targetsNumber;
    public GameObject spawnPlace;
    public float lifeTime;
    public bool canSLow;
    public float slowTimer;
    private void Start()
    {
        speed = 0.1f;
        targetsNumber = 30;
        targets.AddRange(GameObject.FindGameObjectsWithTag("Target"));
        spawnPlace = GameObject.FindGameObjectWithTag("Spawn");
        this.transform.position = spawnPlace.transform.position;
        lifeTime = 150.0f;
        canSLow = false;
        slowTimer = 3.0f;
    }
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(transform.position, targets.ElementAt(currentTarget).transform.position, speed);
        //targets.OrderBy(t => t.name).ToList();
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
        if (canSLow == true)
        {
            slowTimer -= Time.deltaTime;
            speed = 0.01f;
            if (slowTimer <= 0)
            {
                slowTimer = 3.0f;
                speed = 0.1f;
                canSLow = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Target")
        {
            currentTarget++;
        }
    }
}
