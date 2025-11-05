using UnityEngine;

public class animationStateController : MonoBehaviour
{
    Animator animator;
    int isRunningHash;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animator = GetComponent<Animator>();
        isRunningHash = Animator.StringToHash("isRunning");

    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("r");

        if (!isRunning && forwardPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        if (isRunning && !forwardPressed)
        {  
            animator.SetBool(isRunningHash, false); 
        }
    }
}
