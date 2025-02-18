using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnder : MonoBehaviour
{
    // Reset game when ball touches the button
    private void OnCollisionEnter(Collision collision)
    {
        GameMannager.Instance.StartScene();
    }
}
