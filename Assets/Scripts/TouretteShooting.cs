using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TouretteShooting : MonoBehaviour
{
    public float shootingSpeed;
    public Transform shootingPlace;
    public GameObject bullet;
    public GameObject nearestBaloon;
    private void Start()
    {
        shootingSpeed = 0.3f;
    }
    private void Update()
    {
        if (nearestBaloon != null)
        {
            Vector3 Look = transform.InverseTransformPoint(nearestBaloon.transform.position);
            float Angle = Mathf.Atan2(Look.y, Look.x) * Mathf.Rad2Deg;
            transform.Rotate(0, 0, Angle);
            shootingSpeed -= Time.deltaTime;
            if (shootingSpeed <= 0)
            {
                Instantiate(bullet, shootingPlace.transform.position, shootingPlace.transform.rotation);
                shootingSpeed = 0.3f;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        nearestBaloon = collision.gameObject;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        nearestBaloon = null;
    }

}
