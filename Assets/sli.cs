using UnityEngine;
using UnityEngine.UI;

public class FishController : MonoBehaviour
{
    public GameObject[] fishObjects; // Assign all fish in Inspector
    public Slider fishSlider;

    void Start()
    {
        fishSlider.onValueChanged.AddListener(UpdateFishCount);
    }

    void UpdateFishCount(float value)
    {
        int fishToShow = Mathf.RoundToInt(value);

        for (int i = 0; i < fishObjects.Length; i++)
        {
            fishObjects[i].SetActive(i < fishToShow);
        }
    }
}
