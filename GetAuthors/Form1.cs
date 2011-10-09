using System;
using System.Windows.Forms;
using GetAuthors.OptionService;

namespace GetAuthors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OptionClient optionClient = new OptionClient();
            MessageBox.Show("Tên Thành Viên Nhóm : " + optionClient.Getauthors().GroupName + "\nTên Project: " +
                            optionClient.Getauthors().ProjectName);
        }
    }
}
