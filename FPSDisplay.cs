using UnityEngine;
using TMPro;
 
 
[RequireComponent(typeof(TextMeshProUGUI))]
public class FPSDisplay : MonoBehaviour {

	[Header("Attach this script on a GameObject with a TextMeshPro component")]
	[Header("Font Properties")]
	[Tooltip("Change the font settings")]
	public bool enableFontSettings;
	public Color fontColor;
	public float fontSize;

	private TextMeshProUGUI framesPerSecondText;	
	private float delayTime = 1f;
	private float time;
	private int frameCount;

	void Start() 
	{
		framesPerSecondText = GetComponent<TextMeshProUGUI>();

        if (enableFontSettings)
        {
            framesPerSecondText.color = fontColor;
            framesPerSecondText.fontSize = fontSize;
        }
		else
		{
			fontColor = framesPerSecondText.color;
			fontSize = framesPerSecondText.fontSize;
		}
	}
 
	void Update() 
	{
		time += Time.deltaTime;

		frameCount++;

		if (time >= delayTime) {
			// Update frame rate.
			int frameRate = Mathf.RoundToInt((float)frameCount / time);
			framesPerSecondText.text = frameRate.ToString() + " fps";

			time -= delayTime;
			frameCount = 0;
		}
	}
}