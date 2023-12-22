using UnityEngine;

[RequireComponent(typeof(PlayerAnimator))]
[RequireComponent(typeof(PlayerMover))]

public class PlayerController : MonoBehaviour
{

    PlayerAnimator playerAnimator;
    PlayerMover playerMover;

    void Start()
    {
        playerAnimator = GetComponent<PlayerAnimator>();
        playerMover = GetComponent<PlayerMover>();
    }

    void Update()
    {
        var input = Input.GetAxis("Horizontal");
        if (input > 0)
        {
            playerAnimator.WalkRight();
            playerMover.WalkRight();
        }
        else if (input < 0)
        {
            playerAnimator.WalkLeft();
            playerMover.WalkLeft();
        }
    }
}
