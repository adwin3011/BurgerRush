using UnityEngine;

public class CustomerAI : MonoBehaviour
{
    public Transform counter;
    public float moveSpeed = 2f;
    public float waitTime = 3f;

    private float timer;
    private bool arrived = false;
    private Vector3 targetPosition;

    void Start()
    {
        // Walk to a spot in FRONT of the counter, not inside it
        targetPosition = counter.position + new Vector3(0, 0, -3f);
    }

    void Update()
    {
        if (!arrived)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                targetPosition,
                moveSpeed * Time.deltaTime
            );

            if (Vector3.Distance(transform.position, targetPosition) < 0.5f)
            {
                arrived = true;
                timer = waitTime;
            }
        }
        else
        {
            timer -= Time.deltaTime;
            if (timer <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}