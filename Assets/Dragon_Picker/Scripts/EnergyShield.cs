using UnityEngine;

public class EnergyShield : MonoBehaviour
{
    private bool isPaused = false;
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 realMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 position = transform.position;
        position.x = realMousePosition.x;
        transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isPaused == false) {
                isPaused = true;
                Time.timeScale = 0.0f;
            } else {
                isPaused = false;
                Time.timeScale = 1.0f;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        DragonEgg egg = collision.gameObject.GetComponent<DragonEgg>();
        if (egg != null)
            Destroy(gameObject);

        // if (collision.gameObject.TryGetComponent(out DragonEgg egg))
        //   Destroy(gameObject);
    }
}
