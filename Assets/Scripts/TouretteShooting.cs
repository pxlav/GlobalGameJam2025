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
    public float firstShootingSpeed;
    public AudioSource shootingSound;

    private void Start()
    {
        shootingSound = GameObject.FindGameObjectWithTag("ShootSound").GetComponent<AudioSource>();
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
                shootingSpeed = firstShootingSpeed;
                shootingSound.Play();
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
