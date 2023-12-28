public class PlayerInputController : PlayerControllers
{
    void OnJump()
    {
        CallJumpEvent();
    }
    void OnAttack()
    {
        CallAttckEvent();
    }
}
