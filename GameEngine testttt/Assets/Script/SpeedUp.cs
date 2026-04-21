using UnityEngine;

public class SpeedItem : MonoBehaviour
{
    public float speedIncrease = 2f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            PlayerController player = collision.GetComponent<PlayerController>();

            if (player != null)
            {
                player.moveSpeed += speedIncrease;
            }

            Destroy(gameObject); // 아이템 사라짐
        }
    }
}