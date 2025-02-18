using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class GameMannager : MonoBehaviour
{
    private static GameMannager instance;
    private float playerScore = 0;

    public void ResetScore()
    {
        playerScore = 0;
    }
    // Code to load the correct scene
    #region SceneManagement
    public void NextScene()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene >= SceneManager.sceneCountInBuildSettings - 1)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(nextScene);
        }
        if (nextScene == 1)
        {
            ResetScore();
        }
    }

    public void StartScene()
    {
        SceneManager.LoadScene(0);
    }
    #endregion

    // Update the score
    public void AddScore(float score)
    {
        playerScore += score;
        foreach (ScoreDisplay sD in FindObjectsOfType<ScoreDisplay>())
        {
            sD.ChangeScore();
        }
    }

    public static GameMannager Instance
    {
        get
        {
            if( instance == null)
            {
                GameObject aGO = new GameObject("Game Mannager");
                instance = aGO.AddComponent<GameMannager>();
                DontDestroyOnLoad(aGO);

            }
            return instance;
        }
    }

    public float PlayerScore { get { return playerScore; } }
}
