using UnityEngine;

public class Knife : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            // Get the bullet's rigidbody
            Rigidbody bulletRb = other.GetComponent<Rigidbody>();
            
            // Set the bullet's velocity to the opposite direction
            bulletRb.velocity = -bulletRb.velocity;
            
            // Add a force to the bullet to simulate the deflection
            bulletRb.AddForce(transform.up * 500f, ForceMode.Impulse);
        }
    }
}
