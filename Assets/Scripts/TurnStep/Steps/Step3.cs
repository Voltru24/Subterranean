public class Step3 : Step
{
    public override void Execute()
    {
        RaiseReceiveResource(TypeResource.Armament);
        RaiseReceiveResource(TypeResource.Medicines);
    }
}