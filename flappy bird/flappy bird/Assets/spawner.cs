using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    private float timer = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnerpipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnerpipe();
            timer = 0;
        }
    }
    void spawnerpipe() {
        float lowest = transform.position.y - 15;
        float highest = transform.position.y + 4;

        Instantiate(pipe,new Vector3(transform.position.x,Random.Range(lowest,highest), 0), transform.rotation);
    }
}
