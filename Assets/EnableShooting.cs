using UnityEngine;
using System.Collections;

public class EnableShooting : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag =="Hero")
        {
            Destroy(gameObject);
            other.GetComponent<RangedWeapon>().enabled = true;
        }
    }
}
