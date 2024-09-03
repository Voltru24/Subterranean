public class Step5 : Step
{
    public override void Execute()
    {
        RaiseReceiveResource(TypeResource.Food);
        RaiseReceiveResource(TypeResource.Armament);
    }
}
