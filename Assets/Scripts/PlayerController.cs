using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    [SerializeField] private Rigidbody2D _rb;

    private float _moveX;

    private void Update()
    {
        _moveX = Input.GetAxis("Horizontal") * _speed;
    }

    private void FixedUpdate()
    {
        Vector2 velocity = _rb.velocity;
        velocity.x = _moveX;
        _rb.velocity = velocity;
    }

}
