namespace Array
{
    public partial class Form1 : Form
    {
        string[] names = new string[]
        {
            "John",
            "Han",
            "Lee"
        };

        string[] emails = new string[]
        {
            "john@hotmail.com",
            "han123@yahoo.com",
            "lee222@gmail.com"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 477;
            this.Width = 748;

            for (int index = 0; index <= names.GetUpperBound(0); index++)
            {
                cboNames.Items.Add(names[index]);
            }

            cboNames.SelectedIndex = 0;
        }

        private void cboNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblEmail.Text = emails[cboNames.SelectedIndex];
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            System.Array.Resize(ref names, names.Length + 1);
            System.Array.Resize(ref emails, emails.Length + 1);

            names[names.Length - 1] = txtName.Text;
            emails[emails.Length - 1] = txtEmail.Text;

            cboNames.Items.Add(names[names.Length - 1]);

            txtName.Clear();
            txtEmail.Clear();
        }
    }
}