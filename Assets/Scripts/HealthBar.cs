using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    Slider slider;
    Health health;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    void FixedUpdate()
    {
        slider.value = Health.getInstance().health;
    }
}
