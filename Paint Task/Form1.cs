namespace Paint_Task
{
    public partial class Form1 : Form
    {
        Point start, end;

        public Form1()
        {
            InitializeComponent();
        }

        private void Rectangle_Clicked(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            this.Text = lbl.Location.ToString();
        }

        private void Rectangle_DoubleClicked(object sender, MouseEventArgs e)
        {
            Label lbl = sender as Label;
            Controls.Remove(lbl);
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
                
               // Bu hissede komeklik almisam
                Label rectangle = new();
                rectangle.Size = new(width, heigth);
                rectangle.BackColor = Color.Green;
                rectangle.ForeColor = Color.Green;
                int x = start.X - end.X;
                int y = start.Y - end.Y;
                if (x > 0 && y < 0)
                { rectangle.Location = new Point(end.X, start.Y); }
                else if (x < 0 && y > 0)
                { rectangle.Location = new Point(start.X, end.Y); }
                else if (x > 0 && y > 0)
                { rectangle.Location = end; }
                else if (x < 0 && y < 0)
                { rectangle.Location = start; }
                rectangle.MouseClick += Rectangle_Clicked;
                rectangle.MouseDoubleClick += Rectangle_DoubleClicked;
                Controls.Add(rectangle);


            }
        }
    }
}
