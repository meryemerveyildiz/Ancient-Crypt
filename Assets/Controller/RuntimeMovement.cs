using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]

public class RuntimeMovement : MonoBehaviour
{
    private Movement _input;
    private CharacterController _controller;

    private void Start()
    {
        _controller = GetComponent<CharacterController>();
        _input = GetComponent<Movement>();
    }

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        _controller.Move(new Vector3(x: _input.moveVal.x * _input.moveSpeed, y: 0f, z: _input.moveVal.y * _input.moveSpeed));
    }


}
