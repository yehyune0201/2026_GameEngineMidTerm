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

    }
}
