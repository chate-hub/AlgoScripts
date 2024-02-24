using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour
{
    //Fireball flight speed
    public float speed;

    void Update()
    {
        //Each frame the ball position is updated by the product of the forward motion vector (0,0,1),
        //the speed of the ball and the value of the difference in seconds between the last and current frames
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {

        // The enemy is being destroyed
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        //The projectile is destroyed
        Destroy(gameObject);
    }

}
