using UnityEngine;

public class SpectrumObject : MonoBehaviour
{
    public int spectrumIndex = 0;
    public float scaleMultiplier = 50f;
    public float baseScale = 1f;
    public Color baseColor = Color.white;
    public Light cubeLight; // referência à luz

    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (cubeLight == null)
            cubeLight = GetComponentInChildren<Light>(); // pega a luz filha
    }

    void Update()
    {
        float intensity = AudioSpectrum.spectrum[spectrumIndex] * scaleMultiplier;

        // Escala do cubo
        transform.localScale = new Vector3(baseScale, baseScale + intensity, baseScale);

        // Cor do cubo
        rend.material.color = baseColor * (1f + intensity * 5f);

        // Cor + intensidade da luz
        if (cubeLight != null)
        {
            cubeLight.intensity = Mathf.Lerp(0.5f, 5f, intensity * 10f);
            cubeLight.color = Color.Lerp(baseColor, Color.white, intensity * 5f);
        }
    }
}

