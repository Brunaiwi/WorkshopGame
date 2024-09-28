using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIStates : MonoBehaviour
{
    public AIStateType States;

    public void ChangeToState(AIStateType state)
    {
        if (States == state) return;
        
        //Animacao de troca de estado
        //Coisas ao trocar de estado

        States = state;
    }
}
