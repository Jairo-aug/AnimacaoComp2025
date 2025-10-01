using UnityEngine;

public class AudioSpectrum : MonoBehaviour
{
    public AudioSource audioSource;
    public static float[] spectrum = new float[64];

    void Update()
    {
        // Captura o espectro sonoro
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);
    }
}
