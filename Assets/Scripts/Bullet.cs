using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;
    private void OnCollisonEnter2D(Collision2D collision)
    {
        // Bullet damage
        if (collision.gameObject.GetComponent<Health>() != null)
        {
            collision.gameObject.GetComponent<Health>().TakeDamage(damage);
            Debug.Log("Taken Damage");
        }

        // Destroyed the bullet
        Destroy(gameObject);
    }
}
