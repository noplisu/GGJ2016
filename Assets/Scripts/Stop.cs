using UnityEngine;
using System.Collections;

public class Stop : MonoBehaviour {
	void OnEnable()
    {
        Time.timeScale = 0.000001f;
    }

    void OnDisable()
    {
        Time.timeScale = 1;
    }
}
