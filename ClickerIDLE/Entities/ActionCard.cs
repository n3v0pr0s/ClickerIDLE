namespace ClickerIDLE.Entities
{
    public class ActionCard : ObservableObject
    {
        private const float COST_MULTIPLIER = 2;
        private const float CPS_MULTIPLIER = 1.4F;


        /// <summary>
        /// Click per second
        /// </summary>
        public int CPS { get; private set; }
        public string Code { get; }
        public string Name { get; }
        public int Cost { get; private set; }
        public int Level { get; private set; } = 0;

        public ActionCard(string code, string name, int cps, int cost)
        {
            Code = code;
            Name = name;
            CPS = cps;
            Cost = cost;
        }

        public void Upgrade()
        {
            Cost = Convert.ToInt32(Cost * COST_MULTIPLIER);
            CPS = Convert.ToInt32(CPS * CPS_MULTIPLIER);
            Level++;

            OnPropertyChanged(nameof(Cost));
            OnPropertyChanged(nameof(CPS));
            OnPropertyChanged(nameof(Level));
        }
    }
}