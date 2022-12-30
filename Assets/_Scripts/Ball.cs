using UnityEngine;

public class Ball : MonoBehaviour
{
    public Renderer renderer;

    private void Start()
    {
        renderer.material.SetColor("_EmissionColor", Color.blue * -1);
    }

    void Update()
    {
        if (Follower.On)
        {
            renderer.material.SetColor("_EmissionColor", Color.blue * Raycaster.lightIntensity);
        }
        else
        {
            renderer.material.SetColor("_EmissionColor", Color.blue * -1);
        }
    }
}