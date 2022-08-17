namespace SideProject
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditorMenu em = new EditorMenu();
            em.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Map m = new Map();
            m.ShowDialog();
            this.Show();
        }
    }
}