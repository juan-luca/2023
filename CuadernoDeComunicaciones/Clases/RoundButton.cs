using System;
using System.Drawing;
using System.Windows.Forms;

public class RoundButton : Button
{
    public RoundButton()
    {
        // Establecer el tamaño del botón como cuadrado
        this.Width = this.Height = 100; // Ajusta el tamaño según tus necesidades
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 2;
        this.FlatAppearance.BorderColor = Color.DarkGray;
        this.FlatAppearance.MouseOverBackColor = Color.LightGray;
        this.Paint += RoundButton_Paint;
    }

    private void RoundButton_Paint(object sender, PaintEventArgs e)
    {
        // Dibuja el botón como un círculo
        int diameter = Math.Min(this.Width, this.Height);
        Rectangle circle = new Rectangle(0, 0, diameter, diameter);

        // Dibuja el círculo con relieve
        e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        e.Graphics.FillEllipse(Brushes.White, circle);
        e.Graphics.DrawEllipse(new Pen(Color.DarkGray, 2), circle);
    }
}
