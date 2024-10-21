namespace SOLID_Principles.LiskovSubstitution.MostCorrect;

internal class MostCorrect
{
    public abstract class Phone
    {
        private void ConnectToNetwork() { }
        private void DialNumber(int number) { }

        protected abstract Action[] Callbacks { get; set; }

        protected void MakeACall(int number)
        {
            this.ConnectToNetwork();
            this.DialNumber(number);
            foreach (var callback in Callbacks)
            {
                callback();
            };
        }
    }

    public class SmartPhone : Phone
    {
        public SmartPhone()
        {
            Callbacks = [ShowCallOnDisplay];
        }

        protected override Action[] Callbacks { get; set; }

        private void ShowCallOnDisplay() { }
    }
}
