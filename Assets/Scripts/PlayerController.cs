using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmount = 20f;
    [SerializeField] float boostSpeed = 25f;
    [SerializeField] float baseSpeed = 15f;
    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove = true;

    [System.Obsolete]
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }
    
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }
    }

    [Obsolete]
    public void DisableControls(){
        canMove = false;
    }

    void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            surfaceEffector2D.speed = boostSpeed;
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb2d.AddTorque(torqueAmount);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb2d.AddTorque(-torqueAmount);
        }
    }
}
