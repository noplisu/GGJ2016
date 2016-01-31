using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
    static Fade instance;
    Animator animator;

    public static Fade getInstance()
    {
        return instance;
    }

    void Start()
    {
        instance = this;
        animator = GetComponent<Animator>();
    }

    public void invoke()
    {
        animator.SetTrigger("fade");
    }
}
