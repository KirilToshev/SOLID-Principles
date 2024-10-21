namespace SOLID_Principles.LiskovSubstitution.Correct;

internal class Correct
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
            base.MakeACall(number);
            this.ShowCallOnDisplay();
        }
    }
}
