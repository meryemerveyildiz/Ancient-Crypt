using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    private Rigidbody girl;
    public Vector2 moveVal;
    public float moveSpeed = 10;

    private void Awake()
    {
        girl = GetComponent<Rigidbody>();
    }

    public void Moving(InputAction.CallbackContext value)
    {
        //Debug.Log("Performed");
        moveVal = value.ReadValue<Vector2>();
        //Debug.Log(moveVal.x + " " + moveVal.y);
        //girl.AddForce(new Vector3(x: moveVal.x * moveSpeed, y: 0f, z: moveVal.y * moveSpeed), ForceMode.Impulse);
    }


}
