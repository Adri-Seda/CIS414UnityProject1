using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class CanvasNav : MonoBehaviour
{

    public void LoadNextScene()
    {
        GameMannager.Instance.NextScene();
    }

    public void LoadStartScreen()
    {
        GameMannager.Instance.StartScene();
    }
}
