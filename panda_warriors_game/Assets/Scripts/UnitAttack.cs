using UnityEngine;

public class UnitAttack : MonoBehaviour
{
    private void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward);

        if (Physics.Raycast(transform.position, forward))
        {

        }
    }
}