using UnityEngine;

public class SpectrumObject : MonoBehaviour
{
    public int spectrumIndex = 0;   // índice no espectro (0 = grave, 63 = agudo)
    public float scaleMultiplier = 50f;
    public float baseScale = 1f;
    public Color baseColor = Color.white;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        float intensity = AudioSpectrum.spectrum[spectrumIndex] * scaleMultiplier;

        // Escala pulsando
        transform.localScale = new Vector3(baseScale, baseScale + intensity, baseScale);

        // Mudança de cor baseada na intensidade
        rend.material.color = baseColor * (1f + intensity * 5f);
    }
}
