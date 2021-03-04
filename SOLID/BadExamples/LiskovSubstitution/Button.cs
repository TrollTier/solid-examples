namespace SOLID.BadExamples.LiskovSubstitution
{
    public class Button : Control
    {
        public new int X { get => 0; set { return; } }
    }
}
