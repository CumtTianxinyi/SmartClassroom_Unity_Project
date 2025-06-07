using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControlUI : MonoBehaviour
{
    public Light targetLight;
    public Button btnTurnOn;
    public Button btnTurnOff;
    public Button btnChangeColor;
    public Button btnDim;

    private bool isDim = false;
    private Color[] colorOptions = { Color.white, Color.yellow, Color.red };
    private int colorIndex = 0;

    void Start()
    {
        // 给每个按钮绑定点击事件
        btnTurnOn.onClick.AddListener(() => targetLight.enabled = true);
        btnTurnOff.onClick.AddListener(() => targetLight.enabled = false);
        btnChangeColor.onClick.AddListener(ChangeColor);
        btnDim.onClick.AddListener(ToggleBrightness);
    }

    void ChangeColor()
    {
        colorIndex = (colorIndex + 1) % colorOptions.Length;
        targetLight.color = colorOptions[colorIndex];
    }

    void ToggleBrightness()
    {
        isDim = !isDim;
        targetLight.intensity = isDim ? 0.3f : 1.0f;
    }
}
