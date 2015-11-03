using UnityEngine;

public class ClickDrag : MonoBehaviour
{
    public EyeMovement lEye, rEye;
    public GameObject l, r;
    private Vector2 mousePosition;
    private Vector3 originalPosition;
    private GameObject parent;
    private Highlight highlightParent;
    public AudioSource source;
    public AudioClip click,beep;

    // Use this for initialization
    private void Start()
    {
        originalPosition = transform.position;
        parent = transform.parent.gameObject;
        highlightParent = GetComponentInParent<Highlight>();
        source = GetComponentInParent<AudioSource>();
    }

    // Update is called once per frame
    private void Update()
    {
        mousePosition.x = Input.mousePosition.x;
        mousePosition.y = Input.mousePosition.y;
    }

    // sprite is clicked
    public void OnMouseDown()
    {
        if (transform == null) return;
        transform.parent = null;
        lEye.Look(transform);
        rEye.Look(transform);
        source.PlayOneShot(click);
    }

    // sprite is dragged
    public void OnMouseDrag()
    {
        if (transform == null) return;
        lEye.Look(transform);
        rEye.Look(transform);
        transform.position = Camera.main.ScreenToWorldPoint(new Vector3(mousePosition.x, mousePosition.y, 10.0f));
        //source.PlayOneShot(beep);
    }

    public void OnMouseEnter()
    {
        highlightParent.highlight();
    }

    public void OnMouseExit()
    {
        highlightParent.unhighlight();
    }

    public void OnMouseUp()
    {
        lEye.LookAway();
        rEye.LookAway();
        if (OwlScript.Owl.IsVowel)
            return;
        transform.parent = parent.transform;
        transform.position = originalPosition;
    }
}