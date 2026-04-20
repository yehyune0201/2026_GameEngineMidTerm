using UnityEngine;

public class EnemyTranceController : MonoBehaviour
{
    public float moveSpeed = 0.5f;
    public float raycastDIstance = 0.2f;
    public float tranceDistance = 2f;
    private Transform player;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = player.position - transform.position;
        if (direction.magnitude > tranceDistance)
        {
            return;
        }
        Vector2 directtionNormalized = direction.normalized;

        RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, directtionNormalized,raycastDIstance);
        Debug.DrawRay(transform.position, directtionNormalized * raycastDIstance, Color.red);
        foreach (RaycastHit2D raycastHit in hits )
        {
            if(raycastHit.collider != null && raycastHit.collider.CompareTag("Obstacle"))
            {
                Vector3 alternativeDirection = Quaternion.Euler(0f, 0f, -90f) * direction;
                transform.Translate(alternativeDirection * moveSpeed * Time.deltaTime);
            }
            else
            {
                transform.Translate(direction * moveSpeed * Time.deltaTime);
            }
        }

    }
}
