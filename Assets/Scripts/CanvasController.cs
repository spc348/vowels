using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public static CanvasController canvas;
    public AudioClip click, bell;
    AudioSource source;
    public GameObject introPanel, outroPanel;

    private void Awake()
    {
        canvas = this;
    }

    void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void ShowEndPanel()
    {
        gameObject.GetComponent<Canvas>().enabled = true;
        PlayClip(bell);
        introPanel.SetActive(false);
        outroPanel.SetActive(true);
    }

    public void InvokingMethod()
    {
        Invoke("ShowEndPanel", 3f);
    }

    public void PlayClip(AudioClip name)
    {
        source.PlayOneShot(name);
    }
}