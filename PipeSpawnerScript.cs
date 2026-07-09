using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnTime = 2;
    private float timer = 0;
    public float heightOfSet = 10;

    void Update()
    {
        if (timer < spawnTime)
        {
            timer += Time.deltaTime;
        }
       else
{
    Debug.Log("Spawn Pipe");

    float minY = transform.position.y - heightOfSet;
    float maxY = transform.position.y + heightOfSet;

    Instantiate(pipe,
        new Vector3(transform.position.x, Random.Range(minY, maxY), 0),
        transform.rotation);

    timer = 0;
}
    }
}