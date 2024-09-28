<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICombat : MonoBehaviour
{
    [Header("Main Data")]
    private EnemyScritptable brain;

    [Header("Attack Info")]
    [SerializeField] private bool canAttack;
    [SerializeField] private float currentAttackCooldown;

    private NavMeshAgent nav;

    public void Init(EnemyScritptable pBrain)
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AICombat : MonoBehaviour
{
    [Header("Main Data")]
    private EnemyScriptable brain;

    [Header("Attack Info")]
    [SerializeField] private bool canAttack;
    [SerializeField] private float currentAttackCooldown;

    private NavMeshAgent nav;

    public void Init(EnemyScriptable pBrain)
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
    {
        brain = pBrain;

        nav = GetComponent<NavMeshAgent>();
        nav.stoppingDistance = brain.AttackRange;
<<<<<<< HEAD
    }
   public bool CheckAndAttack(Transform target)
    {
        CooldownRecovery();

        if (Vector3.Distance(transform.position, target.position) < brain.AttackRange)
        {
            if (canAttack)
            {
                Attack(target);
            }

            return true;
        }
        return false;
    }

    public void CooldownRecovery()
    {
=======
    }

    public bool CheckAndAttack(Transform target)
    {
        CooldownRecovery();

        if (Vector3.Distance(transform.position, target.position) < brain.AttackRange)
        {
            if (canAttack)
            {
                Attack(target);
            }

            return true;
        }

        return false;
    }

    public void CooldownRecovery()
    {
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
        currentAttackCooldown -= Time.deltaTime;

        if (currentAttackCooldown <= 0)
        {
            canAttack = true;
            currentAttackCooldown = brain.attackSpeed;
        }
<<<<<<< HEAD
    }
   public void Attack(Transform target)
    {
        canAttack = false;

        target.GetComponent<IDamageable>().TakeDamage(Random.Range(brain.AttackDamage[0], brain.AttackDamage[1]));
    }
}
=======
    }

    public void Attack(Transform target)
    {
        canAttack = false;

        target.GetComponent<IDamageable>().TakeDamage(Random.Range(brain.AttackDamage[0], brain.AttackDamage[1]));
    }
}
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
