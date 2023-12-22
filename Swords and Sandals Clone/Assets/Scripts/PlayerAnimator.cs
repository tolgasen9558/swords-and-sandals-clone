using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{

    string triggerWalkLeft = "walk_left";
    string triggerWalkRight = "walk_right";

    Animator animator;
    float animDuration = 0.5f;
    float lastTriggerTime;

    void Start()
    {
        animator = GetComponent<Animator>();
        lastTriggerTime = Time.time;
    }
    public void WalkLeft()
    {
        if (Time.time < lastTriggerTime + animDuration)
            return;

        animator.SetTrigger(triggerWalkLeft);
        lastTriggerTime = Time.time;
    }

    public void WalkRight()
    {
        if (Time.time < lastTriggerTime + animDuration)
            return;

        animator.SetTrigger(triggerWalkRight);
        lastTriggerTime = Time.time;
    }

}
