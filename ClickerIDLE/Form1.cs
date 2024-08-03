using ClickerIDLE.Entities;

namespace ClickerIDLE
{
    public partial class Form1 : Form
    {
        private GameProcess _game;

        public Form1(GameProcess game)
        {
            _game = game;

            InitializeComponent();

            var scoreBinding = new Binding("Text", _game, nameof(_game.Score), false, DataSourceUpdateMode.OnPropertyChanged);
            scoreBinding.Format += (s, e) => e.Value = $"Score: {((int)e.Value).ToString(Settings.NUMBER_FORMAT)}";
            scoreLabel.DataBindings.Add(scoreBinding);

            var cpsBinding = new Binding("Text", _game, nameof(_game.TotalCPS), false, DataSourceUpdateMode.OnPropertyChanged);
            cpsBinding.Format += (s, e) => e.Value = $"CPS: {((int)e.Value).ToString(Settings.NUMBER_FORMAT)}";
            cpsLabel.DataBindings.Add(cpsBinding);

            grid.DataBindings.Add(new Binding("DataSource", _game, nameof(_game.StoreList), false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grid.Columns["Code"].Visible = false;
            grid.Columns["IsAvailableForPurchase"].Visible = false;

            var buyButton = new DataGridViewButtonColumn();
            buyButton.Text = "Buy";
            buyButton.UseColumnTextForButtonValue = true;
            buyButton.FlatStyle = FlatStyle.Flat;
            buyButton.DefaultCellStyle.BackColor = Color.PaleVioletRed;

            grid.Columns.Add(buyButton);
            grid.CellContentClick += grid_cardBuyClick;

            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            while (progressBar.Value < 100)
                progressBar.PerformStep();

            _game.Calculate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _game.Click();
        }

        private void grid_cardBuyClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var isAvailableForPurchase = (bool)grid["IsAvailableForPurchase", e.RowIndex].Value;

                if (e.ColumnIndex == 0 && isAvailableForPurchase)
                {
                    var code = grid["Code", e.RowIndex].Value.ToString();

                    _game.AddCard(code);
                }
            }
        }

        private void grid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in grid.Rows)
            {
                var isAvailableForPurchase = (bool)grid["IsAvailableForPurchase", row.Index].Value;

                if (isAvailableForPurchase)
                    row.Cells[0].Style.BackColor = Color.LightGreen;
                else
                    row.Cells[0].Style.BackColor = Color.PaleVioletRed;
            }
        }
    }
}
