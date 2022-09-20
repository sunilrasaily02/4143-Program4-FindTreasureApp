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
            //hi
        }

        private void OnAppShown(object sender, EventArgs e)
        {
            UpdateHeader();
            CreateGrid(5, 5, new Size(50, 50));
            UpdateFooter();
        }

        private void CreateGrid(int rows, int columns, Size sizeOfCells)
        {
            Size cellSize = sizeOfCells;
            int numColumns = rows;
            int numRows = columns;
            int offsetY = gameHeader.Height;
            for (int c = 0; c < numColumns; c++)
                for (int r = 0; r < numRows; r++)
                {
                    Point point = new Point(c * cellSize.Width, (r * cellSize.Height)+offsetY);
                    GridCell cell = new GridCell(AddButton($"Cell{c}{r}", point, cellSize), new Point(c, r));
                }
            ClientSize = new Size(cellSize.Width * numColumns, (cellSize.Height * numRows)+offsetY+gameFooter.Height);
            GameManager.GenerateIslandLocation(numRows, numColumns);
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

            string text = DetermineTextForTooltip(button.Text[0]);
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
                Text = ""
            };
            Point cellLocation = DetermineCellLocationFromPoint(label.Location, label.Size);
            Debug.WriteLine($"LabelLocation: {label.Location}");
            Debug.WriteLine($"Cell Location: {cellLocation}");
            char hint = GameManager.DetermineIslandDirection(cellLocation);

            label.Text += hint;

            string text = DetermineTextForTooltip(hint);

            toolTip1.SetToolTip(label, text);
            Controls.Add(label);
            Controls.Remove(button);
        }

        private void GridButton_Click(object sender, EventArgs e)
        {
            ReplaceButtonWithLabel(sender as Button);
            GameManager.AddToScore();
            scoreLabel.Text = $"Score: {GameManager.Score}";
            UpdateHeader();
        }

        private string DetermineTextForTooltip(char c)
        {
            switch (c)
            {
                case '~':
                    return "This is a water location, click to reveal a hint.";
                case 'N':
                    return "The island is north of this location!";
                case 'S':
                    return "The island is south of this location!";
                case 'E':
                    return "The island is east of this location!";
                case 'W':
                    return "The island is west of this location!";
                case 'R':
                    return "The island is on this row!!";
                case 'C':
                    return "The island is in this column!!";
                case 'I':
                    return $"Well Done! You've found the island in {GameManager.Score} turns!";
                default:
                    Debug.WriteLine($"Character \'{c}\' not accounted for.");
                    return "Invalid Character";
            }
        }

        private Point DetermineCellLocationFromPoint(Point point, Size size)
        {
            int y = point.Y - gameHeader.Height;
            return new Point(point.X/size.Width, y/size.Height);
        }

        private void UpdateHeader()
        {
            gameHeader.Size = new Size(ClientSize.Width, gameHeader.Height);
            gameHeader.Location = new Point(0, 0);
            scoreLabel.Location = new Point((gameHeader.Width - scoreLabel.Width) / 2, scoreLabel.Location.Y);
        }

        private void UpdateFooter()
        {
            gameFooter.Size = new Size(ClientSize.Width, gameFooter.Height);
            gameFooter.Location = new Point(0, ClientSize.Height-gameFooter.Height);
        }
    }
}
