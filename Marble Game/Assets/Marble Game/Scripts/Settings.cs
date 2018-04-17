using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Settings : MonoBehaviour {

    public Slider mySlider;

    public void OnValueChanged()
    {
        AudioListener.volume = mySlider.value;
    }

    public void changeQuality(int index)
    {
        QualitySettings.SetQualityLevel(index);
    }

    public void setFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }


}
