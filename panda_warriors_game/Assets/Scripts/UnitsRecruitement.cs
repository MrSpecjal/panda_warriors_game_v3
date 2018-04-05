using UnityEngine;

public class UnitsRecruitement : MonoBehaviour
{
    bool notFree = false;
    int rayRange = 1000;
    public Object Unit1;
    public Object Unit2;
    public Object Unit3;
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
    
    public void Spawn(int id)
    {
        uIManager.AddCurrency(0, -100);
        switch (id)
        {
            case 0:
                Instantiate(Unit1, spawnpoint, transform.rotation);
                break;

            case 1:
                Instantiate(Unit2, spawnpoint, transform.rotation);
                break;

            case 2:
                Instantiate(Unit3, spawnpoint, transform.rotation);
                break;
        }
    }
}
