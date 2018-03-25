using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 50f;
    public float scrollingSpeed = 20f;
    public Vector3 cameraRangeMin = new Vector3(0, 20, -40);
    public Vector3 cameraRangeMax = new Vector3(500, 80, 470);

    void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        Vector3 position = transform.position;
        if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height)
        {
            position.z += cameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("s") || Input.mousePosition.y <= 0)
        {
            position.z -= cameraSpeed * Time.deltaTime;
        }
        if (Input.GetKey("d") || Input.mousePosition.x >= Screen.width)
        {
            position.x += cameraSpeed * Time.deltaTime;
        }
        else if (Input.GetKey("a") || Input.mousePosition.x <= 0)
        {
            position.x -= cameraSpeed * Time.deltaTime;
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");
        position.y -= scroll * scrollingSpeed * 50f * Time.deltaTime;
        position.z += scroll * scrollingSpeed * 50f * Time.deltaTime;

        position.x = Mathf.Clamp(position.x, cameraRangeMin.x, cameraRangeMax.x);
        position.y = Mathf.Clamp(position.y, cameraRangeMin.y, cameraRangeMax.y);
        position.z = Mathf.Clamp(position.z, cameraRangeMin.z, cameraRangeMax.z);

        transform.position = position;
    }
}