using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBulletToPlayerController : MonoBehaviour
{

    // Die Geschwindigkeit mit der die Kugel sich in Richtung Spieler bewegen soll.
    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

        // Darüber holen wir uns das Spieler Gameobject via dem Tag. Das muss natürlich im Prefab "Player" auch gesetzt sein.
        GameObject gameObject = GameObject.FindWithTag("Player");

        if (gameObject != null)
        {
            // Das ist der Pfeil, der von der Kugel zum Spieler zeigt. Hierbei im 3D Raum.
            // Normalized brauchen wir hierbei wieder um die Länge des Pfeiles zu normalisieren, also immer gleich lang zu machen.
            Vector3 v3 = (gameObject.transform.position - transform.position).normalized;
            // Nun brechen wir das auf 2 Dimensionen runter, denn wir brauchen ja nur die 2 Dimmensionen.
            Vector2 v2 = new Vector2(v3.x, v3.y);
            // Nun setzen wir die "Velocity" also die Geschwindigkeit des Objektes, welches dieses Script besitzt (z.B. unsere Kugeln)
            GetComponent<Rigidbody2D>().velocity = v2 * speed;
        }


    }

}
