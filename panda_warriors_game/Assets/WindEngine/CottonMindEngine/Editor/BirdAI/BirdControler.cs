using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdControler : MonoBehaviour
{
	private PathEditor path;
	private int currentWaypoint = 0;
	public float speed;
	private float reachDistance = 1.0f;
	public float rotationSpeed = 5.0f;
	public string pathName;
	private string currentPathName;

	Vector3 lastPosition;
	Vector3 currentPosition;

	void Start ()
	{
		OnPathNameChanged();
		lastPosition = transform.position;
	}
		
	void Update ()
	{
		if (path != null)
		{
			float distance = Vector3.Distance(path.waypoints[currentWaypoint].position, transform.position);
			transform.position = Vector3.MoveTowards(transform.position, path.waypoints[currentWaypoint].position, Time.deltaTime * speed);

			Quaternion rotation = Quaternion.LookRotation(path.waypoints[currentWaypoint].position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);

			if (distance <= reachDistance)
			{
				if (pathName != currentPathName)
				{
					OnPathNameChanged();
					return;
				}
				else
					currentWaypoint++;
			}

			if (currentWaypoint >= path.waypoints.Count)
			{
				if (pathName != currentPathName)
				{
					OnPathNameChanged();
					return;
				}
				else
				{
					currentWaypoint = 0;
				}
			}
		}
	}

	PathEditor SetPath(string name)
	{
		PathEditor path;		
		if (GameObject.Find(name) != null)
		{
			path = GameObject.Find(name).GetComponent<PathEditor>();
			return path;
		}
		else
		{
			Debug.LogError("A given path is not existing!\nCheck name of path gameObject and path varible. Then restart scene (in playmode).");
			return null;
		}
	}

	void OnPathNameChanged()
	{
		currentWaypoint = 0;
		if (pathName != null)
		{
			currentPathName = pathName;
		}
		else
		{
			currentPathName = "path1";
		}
		path = SetPath(currentPathName);
	}
}
