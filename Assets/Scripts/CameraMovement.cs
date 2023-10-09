using System.Collections;
using System.Collections.Generic;
using UnityEditor.Networking.PlayerConnection;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] float maxX;
    [SerializeField] float maxY;

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");

        Vector2 playerPos = player.transform.position;

        float posX = Mathf.Clamp(playerPos.x, -maxX, maxX);
        float posY = Mathf.Clamp(playerPos.y, -maxY, maxY);

        transform.position = new Vector3 (posX, posY, -10);
        

    }
}
