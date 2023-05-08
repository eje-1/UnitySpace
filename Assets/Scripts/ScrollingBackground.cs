using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float speed = 5f; // the speed at which the background will move
    public float maxY = 20f; // the maximum height of the background
    public float minY = -20f; // the minimum height of the background

    // Update is called once per frame
    void Update()
    {
        // Move the background downwards at a constant speed
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        // If the background has gone below the minimum height, reset it to the maximum height
        if (transform.position.y <= minY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
    }

}
