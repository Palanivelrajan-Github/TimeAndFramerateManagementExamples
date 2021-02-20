using UnityEngine;

// Time.deltaTime example.
//
// Wait two seconds and display waited time.
// This is typically just beyond 2 seconds.
// Allow the speed of the time to be increased or decreased.
// It can range between 0.5 and 2.0. These changes only
// happen when the timer restarts.

public class TimeDeltaTime : MonoBehaviour
{
    private float scrollBar = 1.0f;
    private float timer;
    private float value = 10.0f;
    private float visualTime;
    private readonly float waitTime = 2.0f;
    private int width, height;

    private void Awake()
    {
        width = Screen.width;
        height = Screen.height;
        Time.timeScale = scrollBar;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime)
        {
            visualTime = timer;

            // Remove the recorded 2 seconds.
            timer = timer - waitTime;
            Time.timeScale = scrollBar;
        }
    }

    private void OnGUI()
    {
        var sliderDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSlider"));
        var sliderThumbDetails = new GUIStyle(GUI.skin.GetStyle("horizontalSliderThumb"));
        var labelDetails = new GUIStyle(GUI.skin.GetStyle("label"));

        // Set the size of the fonts and the width/height of the slider.
        labelDetails.fontSize = 6 * (width / 200);
        sliderDetails.fixedHeight = height / 32;
        sliderDetails.fontSize = 12 * (width / 200);
        sliderThumbDetails.fixedHeight = height / 32;
        sliderThumbDetails.fixedWidth = width / 32;

        // Show the slider. Make the scale to be ten times bigger than the needed size.
        value = GUI.HorizontalSlider(new Rect(width / 8, height / 4, width - 4 * width / 8, height - 2 * height / 4),
            value, 5.0f, 20.0f, sliderDetails, sliderThumbDetails);

        // Show the value from the slider. Make sure that 0.5, 0.6... 1.9, 2.0 are shown.
        var v = Mathf.RoundToInt(value) / 10.0f;
        GUI.Label(new Rect(width / 8, height / 3.25f, width - 2 * width / 8, height - 2 * height / 4),
            "timeScale: " + v.ToString("f1"), labelDetails);
        scrollBar = v;

        // Display the recorded time in a certain size.
        labelDetails.fontSize = 14 * (width / 200);
        GUI.Label(new Rect(width / 8, height / 2, width - 2 * width / 8, height - 2 * height / 4),
            "Timer value is: " + visualTime.ToString("f4") + " seconds.", labelDetails);
    }
}