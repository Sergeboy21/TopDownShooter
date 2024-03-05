using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthPickup : MonoBehaviour
{
    public int healthAmount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Health playerHealth = collision.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healthAmount);
                Destroy(this.gameObject); //Pickup is Destroyed
                Debug.Log("Health pick up +1");
            }
        }
    }

}
