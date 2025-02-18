using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
/*
 Adriana Seda Pagan
 CIS 414
 Feb 2025
*/
public class PlayerPaddle : MonoBehaviour
{
    protected Vector3 moveDir = Vector3.zero;

    [SerializeField,Range(1,20)]
    protected float movSpeed = 1f;
    //[SerializeField, Range(10, 29)]
    //protected float maxSpeed = 25f;

    private void Update()
    {
        MovePaddle();
    }
    // Grab input from action
    public void MoveInput(InputAction.CallbackContext _context)
    {
        Vector2 av2 = _context.ReadValue<Vector2>();
        moveDir.x = av2.x;
        //aMoveDir.z = av2.y;
        
    }

    // Move Paddle
    public void MovePaddle()
    {
        transform.Translate(moveDir * movSpeed * Time.deltaTime);
    }
}
