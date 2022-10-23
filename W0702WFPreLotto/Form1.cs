namespace W0702WFPreLotto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OnGenerate(object sender, EventArgs e)
        {
            Random r = new Random();
            int[] num = new int[6];

            for (int i = 0; i < num.Length; i++)
                num[i] = r.Next(1, 46);

            Array.Sort(num);

            Num1.Text = num[0].ToString();
            Num2.Text = num[1].ToString();
            Num3.Text = num[2].ToString();
            Num4.Text = num[3].ToString();
            Num5.Text = num[4].ToString();
            Num6.Text = num[5].ToString();
        }
    }
}