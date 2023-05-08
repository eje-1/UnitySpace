using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerBulletController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Wir überprüfen, ob das Objekt mit dem wir kollidieren ein Player oder ein Bullet Tag hat
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Bullet")
        {
            // Wenn das der Fall ist, ignorieren wir die Kollision. Der Spieler kann also z.B. druchfliegen.
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            // Wenn die Kollision mit einem anderen Objekt war (z.B. dem Gegner) dann soll dieses Objekt (das welches dieses Script hält)
            // zerstört werden.
            Destroy(gameObject);
            if (collision.gameObject.tag != "Wall")
            {
                // Zusätzlich soll das Objekt mit dem kollidiert wird zerstört werden, wenn es nicht die Wand ist.
                Destroy(collision.gameObject);
            }
        }
    }
}
