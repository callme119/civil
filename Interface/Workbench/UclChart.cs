namespace Framework.Interface.Workbench
{
    public partial class UclChart : System.Windows.Forms.UserControl
    {
        public UclChart()
        {
            InitializeComponent();
        }

        private void UclChart_Load(object sender, System.EventArgs e)
        {
            WinWordControlEx.LoadWord(@"C:/123.doc");
        }

        private void BtnCreate_Click(object sender, System.EventArgs e)
        {
            System.Data.DataTable dtsheet = new System.Data.DataTable();
            WinWordControlEx.InsertChart(dtsheet);
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {

        }
    }
}