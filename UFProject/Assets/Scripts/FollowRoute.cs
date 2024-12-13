using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowRoute : MonoBehaviour
{
    public Transform[] waypoints;
    private int currentWaypointIndex = 0;
    private bool routeCompleted = false;

    public float moveSpeed = 2.5f;

    public Transform player;
    public float activationDistance = 5f;

    public Animator animator;


    // Update is called once per frame
    void Update()
    {
        if (!routeCompleted)
        {
            if (IsPlayerClose())
            {
                UpdateAnimations(true);
                MoveToNextWaypoint();
            }
            else
            {
                UpdateAnimations(false);
            }
        } 
        else
        {
            UpdateAnimations(false);
            gameObject.GetComponent<Collider>().enabled = true;
        }
    }

    void MoveToNextWaypoint()
    {
        if (waypoints.Length == 0) return;

        Transform targetWaypoint = waypoints[currentWaypointIndex];

        //Vector3 direction = (targetWaypoint.position - transform.position).normalized;

        //if (direction.magnitude > 0.1f) 
        //{
        //    Quaternion targetRotation = Quaternion.LookRotation(direction);
        //    transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, 5f * Time.deltaTime);
        //}

        transform.position = Vector3.MoveTowards(transform.position, targetWaypoint.position, moveSpeed * Time.deltaTime);
        transform.forward = (targetWaypoint.position - transform.position).normalized;

        if (Vector3.Distance(transform.position, targetWaypoint.position) < 0.1f)
        {
            //currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;

            currentWaypointIndex++;

            if (currentWaypointIndex >= waypoints.Length)
            {
                routeCompleted = true;
            }
        }
    }

    void UpdateAnimations(bool isMoving)
    {
        animator.SetBool("isRunning", isMoving);
    }

    bool IsPlayerClose()
    {
        return Vector3.Distance(transform.position, player.position) <= activationDistance;
    }
}
