using UnityEngine;
using UnityEngine.UI;

public class WaterShaderToggle : MonoBehaviour
{
    public GameObject waterObject; // The object with the water shader
    public Toggle waterToggle;

    void Start()
    {
        waterToggle.onValueChanged.AddListener(ToggleWater);
    }

    void ToggleWater(bool isOn)
    {
        waterObject.SetActive(isOn); // Enable or disable the water shader object
    }
}
