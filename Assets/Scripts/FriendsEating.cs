using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendsEating : MonoBehaviour
{
    [SerializeField] float minScale;
    [SerializeField] float maxScale;
    [SerializeField] float growthMultiplier;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("RedCoral"))
        {
            Grow();
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("BlueCoral"))
        {
            Shrink();
            Destroy(other.gameObject);
        }

    }

    void Grow()
    {
        float newScaleX = gameObject.transform.localScale.x + growthMultiplier;
        float newScaleY = gameObject.transform.localScale.y + growthMultiplier;

        Mathf.Clamp(newScaleX, minScale, maxScale);
        Mathf.Clamp(newScaleY, minScale, maxScale);

        transform.localScale = new Vector2(newScaleX, newScaleY);
    }

    void Shrink()
    {
        float newScaleX = gameObject.transform.localScale.x - growthMultiplier;
        float newScaleY = gameObject.transform.localScale.y - growthMultiplier;

        Mathf.Clamp(newScaleX, minScale, maxScale);
        Mathf.Clamp(newScaleY, minScale, maxScale);

        transform.localScale = new Vector2(newScaleX, newScaleY);
    }
}
