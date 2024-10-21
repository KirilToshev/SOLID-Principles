namespace SOLID_Principles.LiskovSubstitution.Incorrect;

internal class Incorrect
{
    public abstract class Phone
    {
        private void ConnectToNetwork() { }
        private void DialNumber(int number) { }

        public virtual void MakeACall(int number)
        {
            this.ConnectToNetwork();
            this.DialNumber(number);
        }
    }

    public class SmartPhone : Phone
    {
        private void ShowCallOnDisplay() { }

        public override void MakeACall(int number)
        {
            this.ShowCallOnDisplay();
        }
    }
}
