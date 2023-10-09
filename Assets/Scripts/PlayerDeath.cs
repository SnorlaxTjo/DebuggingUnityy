using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField] LayerMask deadlyLayers;

    Collider2D playerCollider;

    private void Start()
    {
        playerCollider = GetComponent<Collider2D>();
    }

    private void FixedUpdate()
    {
        if (playerCollider.IsTouchingLayers(deadlyLayers))
        {
            SceneManagerExtended.ReloadScene();
        }       
    }
}
