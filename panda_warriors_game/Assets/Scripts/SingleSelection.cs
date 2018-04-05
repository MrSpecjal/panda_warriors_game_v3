using UnityEngine;

public class SingleSelection : MonoBehaviour
{
    const int leftMouseButton = 0;
    private float rayRange = 10000f;
    public GameObject workersRecruitWindow;
    public GameObject attackersRecruitWindow;

    private void Start()
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(leftMouseButton))
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                if (Physics.Raycast(ray, out hit, rayRange))
                {
                    if (hit.collider.tag == "Player")
                    {
                       hit.transform.GetChild(0).gameObject.SetActive(true);
                    }
                }
            }

            else
            {
                if (Physics.Raycast(ray, out hit, rayRange))
                {
                    if (hit.collider.tag == "Player")
                    {
                        transform.GetChild(0).gameObject.SetActive(false);
                        hit.transform.GetChild(0).gameObject.SetActive(true);
                    }
                    if (hit.collider.tag == "Centrum Dowodzenia")
                    {
                        workersRecruitWindow.SetActive(true);
                      //  transform.GetChild(0).gameObject.SetActive(true);
                    }
                    if (hit.collider.tag == "Koszary")
                    {
                        attackersRecruitWindow.SetActive(true);
                       // transform.GetChild(0).gameObject.SetActive(true);
                    }
                    else
                    {
                       transform.GetChild(0).gameObject.SetActive(false);
                    }
                }
                else
                {
                    transform.GetChild(0).gameObject.SetActive(false);
                }
            }
        }
    }
}
