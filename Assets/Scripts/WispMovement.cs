using UnityEngine;
using System.Collections;

public class WispMovement : MonoBehaviour {

    float changeDirectionTime = 2f;
    int direction;
    Rigidbody2D rigidbody;
    Vector2[] directions = { Vector2.up, Vector2.right, Vector2.down, Vector2.left };

    // Use this for initialization
    void Start () {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        changeDirectionTime += Time.deltaTime;
        if (changeDirectionTime > 1f)
        {
            direction = Random.Range(0, 4);
            changeDirectionTime = 0;
        }
        rigidbody.MovePosition(rigidbody.position + directions[direction] * Time.deltaTime);
    }
}
