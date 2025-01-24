using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMannager : MonoBehaviour
{
    private static GameMannager instance;
    private float playerScore = 0;
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
}
