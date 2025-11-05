using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;

    private readonly int hashSpeed = Animator.StringToHash("Speed");
    private readonly int hashJump = Animator.StringToHash("Jump");
    private readonly int hashWeakAttack = Animator.StringToHash("WeakAttack");
    private readonly int hashStrongAttack = Animator.StringToHash("StrongAttack");
    private readonly int hashSpecialAttack = Animator.StringToHash("SpecialAttackPose"); 
    private readonly int hashHurt = Animator.StringToHash("Hurt");

    void Awake()
    {

        animator = GetComponent<Animator>();
    }

    public void SetMovementSpeed(float speed)
    {
        animator.SetFloat(hashSpeed, speed);
    }

    public void TriggerJump()
    {
        animator.SetTrigger(hashJump);
    }

    public void TriggerWeakAttack()
    {
        animator.SetTrigger(hashWeakAttack);
    }

    public void TriggerStrongAttack()
    {
        animator.SetTrigger(hashStrongAttack);
    }

    public void TriggerSpecialAttack()
    {
        animator.SetTrigger(hashSpecialAttack);
    }

    public void TriggerHurt()
    {
        animator.SetTrigger(hashHurt);
    }
}
