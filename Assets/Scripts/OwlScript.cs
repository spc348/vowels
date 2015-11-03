using UnityEngine;

public class OwlScript : MonoBehaviour
{
    public AudioClip hoot;
    private AudioSource source;
    public bool IsVowel;
    public static OwlScript Owl;

    private void Awake()
    {
        Owl = this;
        IsVowel = false;
    }

    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("vowel"))
        {
            IsVowel = true;
            other.transform.parent = this.transform;
            other.transform.position = new Vector3(0f, 0f, 0f);
            WingMovement.Wings.WingDance();
            source.PlayOneShot(hoot);
            CanvasController.canvas.InvokingMethod();
        }
        else
        {
            WingMovement.Wings.Still();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        IsVowel = false;
        //WingMovement.Wings.Still();
    }
}