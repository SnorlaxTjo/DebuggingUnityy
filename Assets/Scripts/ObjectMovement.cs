using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] float maxRandomMove;
    [SerializeField] float maxRandomScale;
    [SerializeField] float minScale;
    [SerializeField] float maxScale;

    private void Update()
    {
        RandomMovement();
        RandomScaling();
    }

    void RandomMovement()
    {
        float movePosX = Random.Range(-maxRandomMove, maxRandomMove);
        float movePosY = Random.Range(-maxRandomMove, maxRandomMove);

        transform.position += new Vector3(movePosX, movePosY, 0);
    }

    void RandomScaling()
    {
        float scaler = Random.Range(minScale, maxScale);
        Mathf.Clamp(scaler, minScale, maxScale);

        transform.localScale = new Vector3(scaler, scaler, 0);
    }
}
