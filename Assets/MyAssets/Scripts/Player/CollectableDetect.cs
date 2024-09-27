using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableDetect : MonoBehaviour
{
    public PlayerHealth playerHealth;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("HealthSpeare"))
        {
            playerHealth.IncreaseHealth(25);
            GameObject healthParent = other.transform.parent.gameObject;
            Destroy(healthParent);
        }
    }
}
