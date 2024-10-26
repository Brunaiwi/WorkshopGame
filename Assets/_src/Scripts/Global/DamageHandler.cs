using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour
{
    [Header("Script References")]
    private CharacterStatusManager StatusScript;
    public MeshRenderer myRenderer;

    private void Start()
    {
        if (gameObject.tag != "Enemy")
        {
            Init();
        }
    }

    private void Init()
    {
        StatusScript = GetComponent<CharacterStatusManager>();
        myRenderer = GetComponentInChildren<MeshRenderer>();

        SubscribeToEvent();
    }

    private void SubscribeToEvent()
    {
        Debug.Log("Se inscrevendo aos eventos");

        StatusScript.OnTakeDamage += BlinkMaterial;
    }
    private void OnDisable()
    {
        Debug.Log("Se desinscrevendo aos eventos");
        StatusScript.OnTakeDamage -= BlinkMaterial;
    }
    private void OnDestroy()
    {
        
    }

    public void BlinkMaterial()
    {
        if (StatusScript == null) 
        { 
          Debug.LogError("Missing status script"); 
          return;
        }
        if (myRenderer == null)
        {
            Debug.LogError("Missing status script");
            return;
        }

        StartCoroutine(BlinkMaterialRoutine());
    }

    IEnumerator BlinkMaterialRoutine()
    {
        var myMaterial = myRenderer.materials[0];
        var myMaterialColor = myMaterial.color;

        myMaterial.color = Color.white;

        yield return new WaitForSeconds(0.2f);

        myMaterial.color = myMaterialColor;

    }
}
