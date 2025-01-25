using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleParticle : MonoBehaviour
{
    public float lifeTime;

    private void Update()
    {
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
