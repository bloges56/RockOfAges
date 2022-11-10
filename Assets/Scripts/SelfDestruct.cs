using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.x < -20f || screenPosition.x > Screen.width + 20f || screenPosition.y < -20f || screenPosition.y > Screen.height + 20f)
        {
            Destroy(gameObject);
        }
    }
}
