using UnityEngine;

public class DragonEgg : MonoBehaviour
{
    [SerializeField] private float bottomY;
    [SerializeField] private ParticleSystem particles;

    private void OnCollisionEnter(Collision collision)
    {
        particles.Play();
        particles.transform.SetParent(null);
        Destroy(gameObject);
    }

    private void Update()
    {
        if (transform.position.y < bottomY)
            Destroy(gameObject);
    }
}
