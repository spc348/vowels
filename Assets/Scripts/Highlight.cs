using UnityEngine;

public class Highlight : MonoBehaviour
{
    public Color startColor, highlightColor;
    private SpriteRenderer rend;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();

        startColor = new Color(199f, 199f, 199f, 1f);
        rend.color = startColor;
    }

    public void highlight()
    {
        rend.color = new Color(0f, 255f, 0f, 1f);
    }

    public void unhighlight()
    {
        rend.color = startColor;
    }
}