using UnityEngine;

public class JumpItem : MonoBehaviour
{
    public float jumpIncrease = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();

            if (player != null)
            {
                player.jumpForce += jumpIncrease;
            }

            Destroy(gameObject);
        }
    }
}