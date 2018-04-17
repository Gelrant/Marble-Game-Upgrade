using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxController : MonoBehaviour {

    public Material firstSkybox;
    public Material secondSkybox;
    public Material thirdSkybox;
    public Material fourthSkybox;

	public void firstButton()
    {
        RenderSettings.skybox = firstSkybox;
    }

    public void secondButton()
    {
        RenderSettings.skybox = secondSkybox;
    }

    public void thirdButton()
    {
        RenderSettings.skybox = thirdSkybox;
    }

    public void fourthButton()
    {
        RenderSettings.skybox = fourthSkybox;
    }
}
