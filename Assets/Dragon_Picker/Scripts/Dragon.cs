using UnityEngine;

public class Dragon : MonoBehaviour
{
    [Header("Set in inspector")]
    [SerializeField] private DragonEgg[] eggPrefabs;
    [SerializeField] private float speed = 5f;
    [SerializeField] private float timeBetweenEggDrop = 2f;
    [SerializeField] private float leftRightDistance = 10f;
    [SerializeField] private float probability = 10f;
    [SerializeField] private Vector3 offset = new Vector3(0f, 5f, 0f);


    private void Start()
    {
        Invoke("EggDrop", 5f);
    }


    private void FixedUpdate()
    {
        Vector3 position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;


        if (position.x >= leftRightDistance) 
            speed = -Mathf.Abs(speed);
        if (position.x <= -leftRightDistance)
            speed = Mathf.Abs(speed);
    }

    public void EggDrop()
    {
        SpawnRandomEgg();

        if (Random.value * 100 < probability)
        {
            SpawnRandomEgg();   
        }

        Invoke("EggDrop", timeBetweenEggDrop);
    }

    private DragonEgg GetRandomPrefab()
    {
        int index = Random.Range(0, eggPrefabs.Length);
        return eggPrefabs[index];
    }

    private void SpawnRandomEgg()
    {
        DragonEgg prefab = GetRandomPrefab();
        DragonEgg egg = Instantiate(prefab);
        egg.transform.position = transform.position + offset;
    }
}
