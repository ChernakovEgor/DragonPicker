using UnityEngine;

public class DragonEgg : MonoBehaviour
{
    [SerializeField] private float bottomY;
    [SerializeField] private ParticleSystem particles;
    private AudioSource _audioSource;

    [SerializeField] private AudioClip _clip;

    private void Awake() {
        _audioSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        particles.Play();
        particles.transform.SetParent(null);
        //_audioSource.Play();
        //AudioSource.PlayClipAtPoint( _clip, transform.position);
        AudioSource.PlayClipAtPoint( _clip, new Vector3(2, 12, 16));
        Destroy(gameObject);
    }

    private void Update()
    {
        if (transform.position.y < bottomY)
            Destroy(gameObject);
    }
}
