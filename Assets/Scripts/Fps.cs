using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Fps : MonoBehaviour
{
    public TextMeshProUGUI FpsText;
    private float pollingTime = 1f;
    private float time;
    private int frameCount;

    void Start()
    {
        Application.targetFrameRate = 120;
    }
    void Update()
    {
        time += Time.deltaTime;

        frameCount++;
        if (time >= pollingTime)
        {
            int frameRate = Mathf.RoundToInt(frameCount / time);
            FpsText.text = frameRate.ToString() + " FPS";

            time -= pollingTime;
            frameCount = 0;
        }
    }
}
