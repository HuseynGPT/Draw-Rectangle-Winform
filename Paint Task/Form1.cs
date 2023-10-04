namespace Paint_Task
{
    public partial class Form1 : Form
    {
        Point start, end;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            start = new(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            end = new(e.X, e.Y);
            int width = Math.Abs(start.X - end.X);
            int heigth = Math.Abs(start.Y- end.Y);

            if (heigth < 10 || width <10) { MessageBox.Show("Recatangle size min 10x10", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else
            {
                
               
                Label rectangle = new();
                rectangle.Size = new(width, heigth);
                rectangle.BackColor = Color.Black;
                rectangle.ForeColor = Color.Black;
                rectangle.Location = new(width, heigth);
                Controls.Add(rectangle);

            }
        }
    }
}