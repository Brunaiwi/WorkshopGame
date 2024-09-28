<<<<<<< HEAD
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
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [Header("Main Data")]
    [SerializeField] private EnemyScriptable brain;

    [Header("Player Reference")]
    [SerializeField] private Transform playerTransform;

    [Header("Transform Data")]
    [SerializeField] private Transform GFXTransform;

    [Header("Scripts References")]
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
    private AIStates AIStatesScript;
    private AIMovement AIMovementScript;
    private AICombat AICombatScript;

<<<<<<< HEAD
    [Header("Reference Check")]
    [SerializeField] private bool referencesOK;



    public void Init(EnemyScritptable pBrain)
    {
        referencesOK = false;
=======
    [Header("References Check")]
    [SerializeField] private bool referencesOk;


    public void Init(EnemyScriptable pBrain)
    {
        referencesOk = false;
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d

        AIStatesScript = GetComponent<AIStates>();
        AIMovementScript = GetComponent<AIMovement>();
        AICombatScript = GetComponent<AICombat>();

        brain = pBrain;

        AICombatScript.Init(brain);

        InstantiateGraphics();
        FindPlayerReference();

<<<<<<< HEAD
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
=======
        referencesOk = true;
    }

    private void Update()
    {
        if (referencesOk == false) return;
        if (playerTransform == null) return;

        if (AIStatesScript.States == AIStateType.CHASING)
        {
            ChaseBehaviour();
            return;
        }

        if (AIStatesScript.States == AIStateType.ATTACKING)
        {
            AttackBehaviour();
            return;
        }


    }

    void ChaseBehaviour()
    {
        var sucess = AIMovementScript.Chase(playerTransform);

        if (sucess == false)
            AIStatesScript.ChangeToState(AIStateType.ATTACKING);
    }

    void AttackBehaviour()
    {
        var sucess = AICombatScript.CheckAndAttack(playerTransform);

        if (sucess == false)
            AIStatesScript.ChangeToState(AIStateType.CHASING);
    }

    void InstantiateGraphics()
    {
        Instantiate(brain.GFX, GFXTransform);
    }

    void FindPlayerReference()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }
}
>>>>>>> ba02bead6ad6f3b3575f03cde0bb072d88eb8e1d
