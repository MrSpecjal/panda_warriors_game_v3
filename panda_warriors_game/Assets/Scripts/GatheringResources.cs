﻿using UnityEngine;

public class GatheringResources : MonoBehaviour
{
    const int rightMouseButton = 1;
    private float rayRange = 10000f;
    bool gathering = false;
    bool isEnded = true;
    bool onColisonEnter = false;
    bool isAnimationEnded = true;
    RaycastHit hit;
    Transform nearestBase;
    public Transform[] basePositions;
    public GameObject[] baseObjects;

    private void Update()
    {
        if (transform.GetChild(0).gameObject.activeSelf)
        {
            if (Input.GetMouseButtonUp(rightMouseButton))
            {
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, rayRange))
                {
                    if (hit.collider.tag == "Kryształy" || hit.collider.tag == "Wrak")
                    {
                        gathering = true;
                    }
                    else
                    {
                        gathering = false;
                    }
                }
            }
        }
        if (gathering)
        {
            Gathering();
        }
    }

    void Gathering()
    {
        if (onColisonEnter == false)
        {
            transform.LookAt(hit.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, hit.transform.position, Movement.speed * Time.deltaTime);
        }
        else
        {
            if (isAnimationEnded)
            {
                isAnimationEnded = false;
            }

            okresl_wspolrzedne();
            nearestBase = GetClosestBase();
            transform.LookAt(nearestBase.position);
            transform.position = Vector3.MoveTowards(transform.position, nearestBase.position, Movement.speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Kryształy" || collision.gameObject.tag == "Wrak")
        {
            onColisonEnter = true;
        }

        else
        {
            if (collision.gameObject.tag == "Centrum Dowodzenia")
            {
                isAnimationEnded = true;
                onColisonEnter = false;
            }
        }
    }

    Transform GetClosestBase()
    {
        Transform bestTarget = null;
        float closestDistanceSqr = Mathf.Infinity;
        Vector3 currentPosition = transform.position;
        foreach (Transform potentialTarget in basePositions)
        {
            Vector3 directionToTarget = potentialTarget.position - currentPosition;
            float dSqrToTarget = directionToTarget.sqrMagnitude;
            if (dSqrToTarget < closestDistanceSqr)
            {
                closestDistanceSqr = dSqrToTarget;
                bestTarget = potentialTarget;
            }
        }
        return bestTarget;
    }

    void okresl_wspolrzedne()
    {
        baseObjects = GameObject.FindGameObjectsWithTag("Centrum Dowodzenia");
        basePositions = new Transform[baseObjects.Length];

        for (int i = 0; i < baseObjects.Length; i++)
        {
            basePositions[i] = baseObjects[i].transform;
        }
    }
}
