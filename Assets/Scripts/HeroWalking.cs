using UnityEngine;
using System.Collections;

public class HeroWalking : MonoBehaviour {

    public float speed;
    Rigidbody2D rigidbody;
    Vector2 movement;
    Hero hero;
    Animator anim;
    private int directionX;
    private int directionY;

    void Awake()
    {
        hero = GetComponent<Hero>();
        rigidbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        directionX = GetDirectionX(hero.direction);
        directionY = GetDirectionY(hero.direction);
        Walk();
        Animate();
    }

    void Walk()
    {
        if (hero.isMoving)
        {
            movement.Set(directionX, directionY);
            movement = movement.normalized * speed * Time.deltaTime;
            rigidbody.MovePosition(rigidbody.position + movement);
        }
    }

    void Animate()
    {
        if (hero.isMoving)
        {
            if (anim != null)
            {
                if (directionX != 0 || directionY != 0)
                {
                    anim.SetFloat("movingH", directionX);
                    anim.SetFloat("movingV", directionY);
                    anim.SetBool("moving", true);
                }
            }
        }
        else
        {
            anim.SetBool("moving", false);
        }
    }

    int GetDirectionX(int code)
    {
        if (code == 1)
            return -1;
        else if (code == 3)
            return 1;
        else
            return 0;
    }

    int GetDirectionY(int code)
    {
        if (code == 2)
            return -1;
        else if (code == 0)
            return 1;
        else
            return 0;
    }
}
