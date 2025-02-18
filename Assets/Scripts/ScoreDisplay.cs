using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    protected TMP_Text scoreText;
    [SerializeField]
    protected string preText = "Score: ";
    [SerializeField]
    protected string postText = " pts";

    public void Start()
    {
        ChangeScore();
    }
    // Update the on screen score
    public void ChangeScore()
    {
        scoreText.text = preText + GameMannager.Instance.PlayerScore + postText;
    }
}
