using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customerPrefab;
    public Transform counter;
    public float spawnInterval = 8f;
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            SpawnCustomer();
            timer = 0f;
        }
    }

    void SpawnCustomer()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-3f, 3f), 1f, -8f);
        GameObject customer = Instantiate(customerPrefab, spawnPos, Quaternion.identity);
        customer.GetComponent<CustomerAI>().counter = counter;
    }
}