using UnityEngine;
using UnityEngine.UI;

public class BubbleController : MonoBehaviour
{
    public ParticleSystem bubbleSystem;
    public Slider bubbleSlider;

    private ParticleSystem.EmissionModule emissionModule;

    void Start()
    {
        emissionModule = bubbleSystem.emission;
        bubbleSlider.onValueChanged.AddListener(UpdateBubbleAmount);
    }

    void UpdateBubbleAmount(float value)
    {
        emissionModule.rateOverTime = value; // Adjust the number of bubbles
    }
}
