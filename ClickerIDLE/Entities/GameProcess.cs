using ClickerIDLE.DTOs;
using ClickerIDLE.Exceptions;

namespace ClickerIDLE.Entities
{
    public class GameProcess : ObservableObject
    {
        private readonly List<ActionCard> _store;
        private readonly List<ActionCard> _activeCards = new();

        private int _score = 0;
        public int Score
        {
            get { return _score; }
            private set
            {
                _score = value;
                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Total click per second
        /// </summary>
        public int TotalCPS => _activeCards.Sum(x => x.CPS);
        public List<ActionCardInfoDto> StoreList => GetStore();

        public GameProcess(List<ActionCard> store)
        {
            _store = store;
        }

        public void Calculate()
        {
            Score += TotalCPS;
        }

        public void AddCard(string cardCode)
        {
            var card = _store.FirstOrDefault(x => x.Code == cardCode);

            if (card == null)
                throw new CardNotExistsException();

            if (card.Cost > Score)
                throw new CardTooExpensiceException();

            Score -= card.Cost;
            _activeCards.Add(card);
            card.Upgrade();

            OnPropertyChanged(nameof(TotalCPS));
        }

        public void Click()
        {
            Score += 150;
        }

        private List<ActionCardInfoDto> GetStore()
        {
            var result = _store.Select(x => new ActionCardInfoDto
            {
                Code = x.Code,
                Name = x.Name,
                Cost = x.Cost.ToString(Settings.NUMBER_FORMAT),
                LVL = x.Level,
                CPS = x.CPS.ToString(Settings.NUMBER_FORMAT),
                IsAvailableForPurchase = Score >= x.Cost

            }).ToList();

            return result;
        }
    }
}
