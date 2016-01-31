using UnityEngine;
using System.Collections;

public class destroyOverTime : MonoBehaviour {
    public float time = 3;
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;
        if(time <= 0)
        {
            Destroy(gameObject);
        }
	}
}
