using UnityEngine;
using System.Collections;

public class UsableDetector : MonoBehaviour {
    public float range = 1;
    Hero hero;
    public LayerMask mask;

    Vector2[] directions = { Vector2.up, Vector2.left, Vector2.down, Vector2.right };
    
    void Awake () {
        hero = GetComponent<Hero>();
	}
	
	void FixedUpdate () {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            RaycastHit2D raycastHit = Physics2D.Raycast(transform.position, directions[hero.direction], range, mask);
            if (raycastHit)
            {
                UsableInterface usable = raycastHit.transform.GetComponent<UsableInterface>();
                if(usable != null)
                    usable.Use();
            }
        }
	}
}
