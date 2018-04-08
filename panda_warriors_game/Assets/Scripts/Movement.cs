using UnityEngine;
using UnityEngine.AI;

public class Movement : MonoBehaviour
{
    public static float speed = 10; //szybkosc poruszania sie jednostki
    public float ray_range = 10000f;
    public NavMeshAgent agent;

    private const int right_mouse_button = 1;
    private Vector3 targetPosition; //pozycja jednostki
    private bool isMoving; //czy jednostka sie porusza

    void Start() //inicjalizacja
    {

        targetPosition = transform.position;
        isMoving = false;
    }

    void Update() //raz na klatke
    {
        if (transform.GetChild(0).gameObject.activeSelf) //jesli pole zaznaczania aktywne
        {
            RaycastHit proba;
            Ray checker = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Input.GetMouseButton(right_mouse_button)) //przy nacisnieciu RMB
            {
                if (Physics.Raycast(checker, out proba, ray_range))
                {
                    if (proba.collider.tag == "Terrain")
                    {
                        SetTargetPosition(proba.point
                            ); //wybiera nowa pozycje dla jednostki
                    }
                }
            }
        }

        if (isMoving)
            MovingPlayer();
    }

    void SetTargetPosition(Vector3 position) //strzela niewidzialnym promieniem i ustawia w tym punkcie nowa pozycje dla jednostki
    {
        agent.SetDestination(position);
        //Plane plane = new Plane(Vector3.up, transform.position);
        //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //float point = 0f;

        //if (plane.Raycast(ray, out point))
            //targetPosition = ray.GetPoint(point);

        //isMoving = true;
    }

    void MovingPlayer() //pilnuje zeby jednostka sie poruszala do momentu az dotrze do nowej pozycji
    {
        transform.LookAt(targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        //agent.destination = Vector3.MoveTowards(transform.position, targetPosition, speed * 1000 * Time.deltaTime);
        if (transform.position == targetPosition)
            isMoving = false;

        Debug.DrawLine(transform.position, targetPosition, Color.red);
    }
}