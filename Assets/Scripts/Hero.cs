using UnityEngine;
using System.Collections;
using System;

public class Hero : MonoBehaviour {
    
    public int direction;
    public bool isMoving;

	void FixedUpdate () {
        SetDirection();
    }

    private void SetDirection()
    {
        float directionX = Input.GetAxisRaw("Horizontal");
        float directionY = Input.GetAxisRaw("Vertical");
        if(directionY > 0)
        {
            direction = 0;
        }else if(directionX < 0){
            direction = 1;
        }else if(directionY < 0)
        {
            direction = 2;
        }else if(directionX > 0)
        {
            direction = 3;
        }

        isMoving = (directionX != 0 || directionY != 0);
    }

    
}
