using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alternativemovement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(.02f,0,0 * .1f);
        transform.Rotate(0, 0, .2f, Space.Self);
    }
}
