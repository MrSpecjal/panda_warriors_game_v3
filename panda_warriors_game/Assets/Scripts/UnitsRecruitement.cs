using UnityEngine;

public class UnitsRecruitement : MonoBehaviour
{
    bool notFree = false;
    int rayRange = 1000;
    public Object Unit1;
    public Object Unit2;
    public Object Unit3;
    Vector3 position = new Vector3(70, 5, 50); //do wywalenia jak bedzie system stawiania budynkow

    private void Start()
    {
        Vector3 position = transform.position;
        position.z = position.z - 10;
    }

    void Update()
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                Instantiate(Unit1, position, transform.rotation);
            }
        }

        if (transform.GetChild(0).gameObject.activeSelf)
        {
            if (Input.GetKeyUp(KeyCode.R))
            {
                Instantiate(Unit2, position, transform.rotation);
            }
        }

        if (transform.GetChild(0).gameObject.activeSelf)
        {
            if (Input.GetKeyUp(KeyCode.T))
            {
                Instantiate(Unit3, position, transform.rotation);
            }
        }
    }
}
