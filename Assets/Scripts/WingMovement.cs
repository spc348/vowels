using UnityEngine;

public class WingMovement : MonoBehaviour
{
    public static WingMovement Wings;
    private Animator animator;

    private void Awake()
    {
        Wings = this;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void WingDance()
    {
        animator.Play("OwlFlapping");
    }

    public void Still()
    {
        animator.Play("Idle");
    }
}