using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingAnimation : MonoBehaviour
{
    public Animator shootingAnimator;
    public string[] animationClipsNames; // 0 - idle 1 - shooting
    public TouretteShooting touretteShooting;
    private void Update()
    {
        if(touretteShooting.nearestBaloon != null)
        {
            shootingAnimator.Play(animationClipsNames[1]);
        }
        else
        {
            shootingAnimator.Play(animationClipsNames[0]);
        }
    }
}
