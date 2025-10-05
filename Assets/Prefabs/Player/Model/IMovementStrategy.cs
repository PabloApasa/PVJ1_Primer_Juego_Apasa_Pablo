using System;
using UnityEngine;

public class SmoothMovement : IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction)
    {
        //float moveInX = Input.GetAxis("Horizontal") * player.Velocity * Time.deltaTime;
        float moveInX = direction * player.Velocity * Time.deltaTime;
        transform.Translate(moveInX, 0, 0);
    }
}

public interface IMovementStrategy
{
    public void Move(Transform transform, Player player, float direction);
}

public class AcelerateMovement : IMovementStrategy
{
    private float currentSpeed = 0f;
    //private float acceleration = 2f; // Aceleración por segundo
    
    public void Move(Transform transform, Player player, float direction)
    {
       //currentSpeed += Input.GetAxis("Horizontal") * player.Acceleration * Time.deltaTime;
       //player.Velocity = Mathf.Clamp(currentSpeed, -player.Velocity, player.Velocity);
       // transform.Translate(currentSpeed * Time.deltaTime, 0, 0);
        float movement = direction * player.Velocity * Time.deltaTime;
        //transform.Translate(movement * Time.deltaTime, 0 , 0);
        transform.Translate(movement, 0 , 0);
    }
}





