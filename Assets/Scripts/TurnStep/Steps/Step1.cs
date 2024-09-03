public class Step1 : Step
{
    public override void Execute()
    {
        RaiseReceiveResource(TypeResource.Food);
        RaiseReceiveResource(TypeResource.Medicines);
    }
}
