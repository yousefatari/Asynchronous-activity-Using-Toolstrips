namespace Using_Toolstrips
{
    public partial class Form1 : Form
    {
        int size = 12;
        public Form1()
        {
            InitializeComponent();
        }

        private void lbltexthere_Click(object sender, EventArgs e)
        {

        }

        private void tstxb_TextChanged(object sender, EventArgs e)
        {
            this.lbltexthere.Text = tstxb.Text;
        }

        private void E(object sender, EventArgs e)
        {

        }

        private void tsbig_Click(object sender, EventArgs e)
        {
            this.lbltexthere.Font = new Font("tahoma",size);
            size += 4;
        }

        private void tssmall_Click(object sender, EventArgs e)
        {
            if(size == 0)
            {
                size = 12;
            }
            this.lbltexthere.Font = new Font("tahoma", size);
            size -= 4;
        }
    }
}