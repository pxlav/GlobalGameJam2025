using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D rb;
    public float lifeTime;
    private void Start()
    {
        lifeTime = 7.0f;
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
}
