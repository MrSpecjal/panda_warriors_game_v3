using UnityEngine;

public class UnitsRecruitement : MonoBehaviour
{
    bool notFree = false;
    int rayRange = 1000;
    public Object Unit1slot;
    public Object Unit2slot;
    public Object Unit3slot;
    public Object Unit1upgradedSlot;
    public Object Unit2upgradedSlot;
    public Object Unit3upgradedSlot;
    public bool Unit1upgraded = false;
    public bool Unit2upgraded = false;
    public bool Unit3upgraded = false;
    public Transform spawnObject;
    public Vector3 spawnpoint;
    public UIManager uIManager;

    private void Start()
    {
        uIManager = FindObjectOfType<UIManager>();
        spawnpoint = spawnObject.transform.position;
        Vector3 position = transform.position;
        position.z = position.z - 10;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            if (transform.GetChild(0).gameObject.activeSelf)
            {
                Unit1upgraded = true;
                uIManager.AddCurrency(0, -1000);
            }
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            if (transform.GetChild(0).gameObject.activeSelf)
            {
                Unit2upgraded = true;
                uIManager.AddCurrency(0, -1000);
            }
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            if (transform.GetChild(0).gameObject.activeSelf)
            {
                Unit3upgraded = true;
                uIManager.AddCurrency(0, -1000);
            }
        }
    }

    public void Spawn(int id)
    {
        uIManager.AddCurrency(0, -100);
        switch (id)
        {
            case 0:
                if (Unit1upgraded == true)
                {
                    Instantiate(Unit1upgradedSlot, spawnpoint, transform.rotation);
                    break;
                }
                Instantiate(Unit1slot, spawnpoint, transform.rotation);
                break;

            case 1:
                if (Unit2upgraded == true)
                {
                    Instantiate(Unit2upgradedSlot, spawnpoint, transform.rotation);
                    break;
                }
                Instantiate(Unit2slot, spawnpoint, transform.rotation);
                break;

            case 2:
                if (Unit3upgraded == true)
                {
                    Instantiate(Unit3upgradedSlot, spawnpoint, transform.rotation);
                    break;
                }
                Instantiate(Unit3slot, spawnpoint, transform.rotation);
                break;
        }
    }
}
