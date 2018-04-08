using UnityEngine;
using UnityEngine.AI;

public class TowerMovement : MonoBehaviour
{
    public Transform enemy;
    public float rotateSpeed;
    public float shootDistance;
    public Transform radar;
    public string tag;
    public GameObject particle;
    public Transform enemyBase;
    private NavMeshAgent agent;
    bool isKilled = false;
    private float attackTimer;


    private void Start()
    {
        attackTimer = 5;
        agent = GetComponent<NavMeshAgent>();
        enemyBase = GameObject.FindGameObjectWithTag("EnemyBase").transform;
    }

    void Update()
    {
        // AttackSystem();  
        attackTimer -= Time.deltaTime;
        if (enemy != null)
        {
            agent.Stop();
            if (attackTimer <= 0)
            {
                AttackSystem();
                attackTimer = 5;
            }
            float distance = Vector3.Distance(transform.position, enemy.transform.position);

            if (distance > shootDistance)
            {
                enemy = null;
            }

            gameObject.transform.LookAt(enemy.position);

        }
        else
        {
            if (tag == "Player")
            {
                agent.SetDestination(enemyBase.position);
            }
            //transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(0f, 0f, 0f), Time.deltaTime * rotateSpeed);
            DystanceSystem2();
        }

    }

    void DystanceSystem()
    {
        GameObject obj = GameObject.FindGameObjectWithTag(tag);
        float distance = Vector3.Distance(transform.position, obj.transform.position);

        if (distance <= shootDistance)
        {
            enemy = obj.transform;
        }
    }

    void DystanceSystem2()
    {
        GameObject[] obj = GameObject.FindGameObjectsWithTag(tag);

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
        //Vector3 targetoint = new Vector3(enemy.transform.position.x, transform.position.y, enemy.transform.position.z) - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(targetoint, Vector3.up);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, Time.deltaTime * rotateSpeed);
        //Instantiate(particle);
    }
}
