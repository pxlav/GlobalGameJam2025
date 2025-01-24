using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class Bubble : MonoBehaviour
{
    public float speed;
    public int currentTarget;
    public List<Transform> targets;
    public int targetsNumber;
    public Transform[] targetsToAdd;
    private void Start()
    {
        speed = 0.5f;
        targetsNumber = 4;
        targets.AddRange(GameObject.FindGameObjectsWithTag("Target"));
    }
    private void Update()
    {
        this.transform.position = Vector3.MoveTowards(transform.position, targets.ElementAt(currentTarget).transform.position, speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Target")
        {
            currentTarget++;
        }
    }
}
