using UnityEngine;
using UnityEngine.UI;
public class Speed : MonoBehaviour
{
    public Slider speedSlider;
    public Text speedText;
    public static float speed;

    void Update ()
    {
        speed = speedSlider.value;
        speedText.text = "Speed = " + speed.ToString("f0");
    }
}
