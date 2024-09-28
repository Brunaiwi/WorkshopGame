using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AIMovement : MonoBehaviour
{
    private NavMeshAgent nav;

<<<<<<< HEAD

=======
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
    }

<<<<<<< HEAD
   public bool Chase(Transform target)
    {
        if (!target) return false;

        if (Vector3.Distance(transform.position, target.position) > nav.stoppingDistance)
        {
            nav.SetDestination(target.position);
            return true;
        }

        return false;
=======
    public bool Chase(Transform target)
    {
        if (!target) return false;

        if (Vector3.Distance(transform.position, target.position) > nav.stoppingDistance)
        {
            nav.SetDestination(target.position);
            return true;
        }

        return false;       
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
    }
}
