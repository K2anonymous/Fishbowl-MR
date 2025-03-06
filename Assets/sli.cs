using UnityEngine;
using UnityEngine.UI;

public class FishController : MonoBehaviour
{
    public Slider fishSlider; // The slider to control the bird count
    private NVBoids nvBoids; // Reference to NVBoids script

    void Start()
    {
        // Find the NVBoids script (assuming it's attached to the same GameObject or another GameObject)
        nvBoids = FindObjectOfType<NVBoids>();

        // Add listener to the slider to update BirdsNum in NVBoids when slider changes
        fishSlider.onValueChanged.AddListener(UpdateBirdsNum);
    }

    void UpdateBirdsNum(float value)
    {
        if (nvBoids != null)
        {
            // Update the BirdsNum in NVBoids based on the slider value
            nvBoids.birdsNum = Mathf.RoundToInt(value);
        }
    }
}
