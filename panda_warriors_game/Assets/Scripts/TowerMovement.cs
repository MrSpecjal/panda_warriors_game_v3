using UnityEngine;

public class TowerMovement : MonoBehaviour
{
    public Transform enemy;
    public float rotateSpeed;
    public float shootDistance;
    public Transform radar;
    
    void Update()
    {
        // AttackSystem();  
        
        if (enemy != null)
        {
            AttackSystem();
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance > shootDistance)
            {

                enemy = null;
            }
        }
        else
        {
           transform.localRotation  = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0f,0f,0f), Time.deltaTime * rotateSpeed);
           DystanceSystem2();
        }
    }

    void DystanceSystem()
    {
        GameObject obj = GameObject.FindGameObjectWithTag("Enemy");
        float distance = Vector3.Distance(transform.position, obj.transform.position);

        if (distance <= shootDistance)
        {
            enemy = obj.transform;
        }
    }

    void DystanceSystem2()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Enemy");        

        for (int i = 0; i < obj.Length; i++)
        {
            GameObject gameObj = obj[i];
            float distance = Vector3.Distance(transform.position, gameObj.transform.position);

            if (distance <= shootDistance)
            {
                enemy = gameObj.transform;
            }
        }
    }


    void AttackSystem()
    {
        Vector3 targetoint = new Vector3(enemy.transform.position.x, transform.position.y, enemy.transform.position.z) - transform.position;
        Quaternion rotation = Quaternion.LookRotation(targetoint, Vector3.up);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime * rotateSpeed);
    }
}
