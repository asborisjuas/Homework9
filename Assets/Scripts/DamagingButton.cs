public class DamagingButton : ChangingHealthButton
{
    public override void OnButtonClick()
    {
        Character.Damage(Amount);
    }
}
