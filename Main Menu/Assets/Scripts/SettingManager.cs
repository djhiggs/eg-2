using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SettingManager : MonoBehaviour {

    public Toggle fullscreenToggle;
    public Dropdown resolutionDropdown;
    public Dropdown textureQualityDropdown;
    public Dropdown antialiasingDropdown;
    public Dropdown vSyncDropdown;
    public Slider masterVolumeSlider;


    public Resolution[] resolutions;
    public GameSettings gameSettings;

    //Check for mess up here

    void OnEnable()
    {
        gameSettings = new GameSettings();

        fullscreenToggle.onValueChanged.AddListener(delegate { OnFullScreenToggle(); });
        resolutionDropdown.onValueChanged.AddListener(delegate { OnResolutionChange(); });
        textureQualityDropdown.onValueChanged.AddListener(delegate { OnTextureQualityChange(); });
        antialiasingDropdown.onValueChanged.AddListener(delegate { OnAntialiasingChange(); });
        vSyncDropdown.onValueChanged.AddListener(delegate { OnVsyncChange(); });
        masterVolumeSlider.onValueChanged.AddListener(delegate { OnMasterVolumeChange(); });


        resolutions = Screen.resolutions;
    }
    public void OnFullScreenToggle()
    {
       gameSettings.fullscreen = Screen.fullScreen = fullscreenToggle.isOn;

    }

    public void OnResolutionChange()
    {
        Resolution[] resolutions = Screen.resolutions;
        foreach (Resolution res in resolutions)
        {
            print(res.width + "x" + res.height);
        }
    }
    public void OnTextureQualityChange()
    {
       QualitySettings.masterTextureLimit = gameSettings.textureQuality = textureQualityDropdown.value;
        
    }
    public void OnAntialiasingChange()
    {

    }
    public void OnVsyncChange()
    {

    }
    public void OnMasterVolumeChange()
    {

    }
    public void SaveSettings()
    {

    }
    public void LoadSettings()
    {

    }
}
