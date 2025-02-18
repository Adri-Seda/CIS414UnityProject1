using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class RoundManager : MonoBehaviour
{
    [SerializeField] protected GameObject canvasScene;

    private void Update()
    {
        EndRound();
    }
    
    
    private void Awake()
    {
        RoundManager[] gameObjects = FindObjectsOfType<RoundManager>();

        if (gameObjects.Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // at end round activate canvas
    protected void EndRound()
    {
        if (FindObjectsOfType<BreakableBrick>().Length < 1)
        {
            canvasScene.SetActive(true);
        }
    }
}
