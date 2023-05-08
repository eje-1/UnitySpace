using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" || collision.gameObject.tag == "Bullet")
        {
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            Destroy(collision.gameObject);
            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}
