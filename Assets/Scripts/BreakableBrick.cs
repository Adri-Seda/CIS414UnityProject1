using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class BreakableBrick : MonoBehaviour
{
    [SerializeField,Range(1,20)]
    protected int hitsToBreak;
    [SerializeField, Range(1, 20)]
    protected int pointValue;
    protected int curHitsToBreak = 0;
    [SerializeField]
    ParticleSystem hitPs;

    // On script startup set hits that brick has to break
    private void Awake()
    {
        curHitsToBreak = hitsToBreak;
    }

    // Damage the brick
    public void Break(int damage)
    {
        curHitsToBreak -= damage;
        hitPs.Play();
        BreakBrick();
    }

    // Break the brick
    protected void BreakBrick()
    {
        if (curHitsToBreak < 0)
        {
            GameMannager.Instance.AddScore(pointValue);
            Destroy(gameObject);
        }

    }
}
