using UnityEngine;

public class controller : MonoBehaviour
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
        bool Running = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey("w");
        if (!Running && forwardPressed)
        {
            animator.SetBool(isRunningHash, true);
        }
        if (Running && !forwardPressed)
        {   animator.SetBool(isRunningHash, false); }
    }
}
