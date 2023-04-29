using UnityEngine;

public class EnergyShield : MonoBehaviour
{
    private bool isPaused = false;
    private float offset = 0;
    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -Camera.main.transform.position.z;
        Vector3 realMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 position = transform.position;
        position.x = realMousePosition.x + offset;
        if (!isPaused)
            transform.position = position;

        if (Input.GetKeyDown(KeyCode.Space)) {
            if (isPaused == false) {
                isPaused = true;
            } else {
                isPaused = false;
                offset = - realMousePosition.x + transform.position.x;
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
