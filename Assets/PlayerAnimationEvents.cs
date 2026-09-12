using UnityEngine;

public class PlayerAnimationEvents : MonoBehaviour
{
    private Player player;
    private void Awake()
    {
        player = GetComponentInParent<Player>();
    }
    private void DisableMovementandJump() => player.EnableMovementandJump(false);

    private void EnableMovementandJump()=> player.EnableMovementandJump(true);
}