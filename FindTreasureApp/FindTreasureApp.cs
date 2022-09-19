using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FindTreasureApp
{
    public partial class FindTreasureApp : Form
    {
        public FindTreasureApp()
        {
            InitializeComponent();
        }

        private void OnAppShown(object sender, EventArgs e)
        {
            int cellSize = 50;
            int numColumns = 5;
            int numRows = 5;
            for (int c = 0; c < numColumns; c++)
                for(int r = 0; r < numRows; r++)
                    AddButton($"Button{c}{r}", new Point(c*cellSize, r*cellSize), new Size(cellSize, cellSize));

            ClientSize = new Size(cellSize * numColumns, cellSize * numRows);
        }

        private Button AddButton(string name, Point location, Size size)
        {
            Button button = new Button
            {
                Name = name,
                Text = "~",
                TextAlign = ContentAlignment.MiddleCenter,
                Location = location,
                Size = size,
                BackColor = Color.Blue,
                ForeColor = Color.White,
        };

            string text = GetTextForTooltip(button.Text[0]);
            toolTip1.SetToolTip(button, text);

            // Add a Button Click Event handler  
            button.Click += new EventHandler(GridButton_Click);

            // Add Button to the Form. Placement of the Button  
            // will be based on the Location and Size of button  
            Controls.Add(button);

            return button;
        }

        private void ReplaceButtonWithLabel(Button button)
        {
            Label label = new Label
            {
                Name = button.Name,
                Location = button.Location,
                Size = button.Size,
                TextAlign = button.TextAlign,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = button.BackColor,
                ForeColor = button.ForeColor,

                //label.BackColor = Color.Tan;
                //label.ForeColor = Color.Black;
                Text = "N"
            };

            string text = GetTextForTooltip(label.Text[0]);
            toolTip1.SetToolTip(label, text);

            label.MouseHover += new EventHandler(Label_MouseHover);
            Controls.Add(label);
            Controls.Remove(button);
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            ReplaceButtonWithLabel(sender as Button);
        }

        private void Label_MouseHover(object sender, EventArgs e)
        {
            if (sender is Label) { }
        }

        private string GetTextForTooltip(char c)
        {
            switch (c)
            {
                case '~':
                    return "This is a water location, click to reveal a hint.";
                case 'N':
                    return "The island is north of this location!";
   
                default:
                    Debug.WriteLine($"Character \'{c}\' not accounted for.");
                    return "Invalid Character";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
