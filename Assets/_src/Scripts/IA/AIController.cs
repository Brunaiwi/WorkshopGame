using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControler : MonoBehaviour
{
    [Header("Main Data")]
    [SerializeField] private EnemyScritptable brain;

    [Header("Player Reference")]
    [SerializeField] private Transform playerTransform;

    [Header("Transform Data")]
    [SerializeField] private Transform GFXTransform;

    [Header("Scripts References")]
    private AIStates AIStatesScript;
    private AIMovement AIMovementScript;
    private AICombat AICombatScript;

    [Header("Reference Check")]
    [SerializeField] private bool referencesOK;



    public void Init(EnemyScritptable pBrain)
    {
        referencesOK = false;

        AIStatesScript = GetComponent<AIStates>();
        AIMovementScript = GetComponent<AIMovement>();
        AICombatScript = GetComponent<AICombat>();

        brain = pBrain;

        AICombatScript.Init(brain);

        InstantiateGraphics();
        FindPlayerReference();

        referencesOK = true;
    }
    private void Update()
    {
        if (referencesOK == false) return;
        if (playerTransform == null) return;

        if (AIStatesScript.States == AIStateType.chasing)
        {
            ChaseBehavior();
            return;
        }
        if (AIStatesScript.States == AIStateType.attacking)
        {
            AttackBehavior();
            return ;
        }
    }

    void ChaseBehavior()
    {
      var sucess = AIMovementScript.Chase(playerTransform);

        if (sucess == false)
            AIStatesScript.ChangeToState(AIStateType.attacking);
    }

    void AttackBehavior()
    {
        var sucess = AICombatScript.CheckAndAttack(playerTransform);

        if (sucess == false)
            AIStatesScript.ChangeToState(AIStateType.chasing);
    }

    void InstantiateGraphics()
    {
        Instantiate(brain.GXF, GFXTransform);
    }

    void FindPlayerReference()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player")?.transform;
    }
}
