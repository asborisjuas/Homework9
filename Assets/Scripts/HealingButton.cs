public class HealingButton : ChangingHealthButton
{
    public override void OnButtonClick()
    {
        Character.Heal(Amount);
    }
}
