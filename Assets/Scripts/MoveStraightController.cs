using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStraightController : MonoBehaviour
{
    public Vector2 velocity;
    Rigidbody2D rigB2;
    // Start is called before the first frame update
    void Start()

    {
        rigB2 = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        rigB2.velocity = velocity;
    }
}
