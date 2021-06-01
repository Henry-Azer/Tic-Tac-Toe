using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;

namespace TicTacToe
{
    public class Form1 : Form
    {
        private Button _button1;
        private Button _button2;
        private Button _button3;
        private Button _button4;
        private Button _button5;
        private Button _button6;
        private Button _button7;
        private Button _button8;
        private Button _button9;
        private Button _playButton;

        private Button[] _buttonArray;
        private bool _isX;
        private bool _isGameOver; 
        
        private readonly Container _components = null;

        public Form1()
        {
            InitializeComponent();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_components != null)
                {
                    _components.Dispose();
                }
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        
        private void InitializeComponent()
        {
            this._button1 = new Button();
            this._button2 = new Button();
            this._button3 = new Button();
            this._button4 = new Button();
            this._button5 = new Button();
            this._button6 = new Button();
            this._button7 = new Button();
            this._button8 = new Button();
            this._button9 = new Button();
            this._playButton = new Button();
            this.eventShow = new Label();
            this.SuspendLayout();
            // 
            // _button1
            // 
            this._button1.FlatAppearance.BorderSize = 0;
            this._button1.FlatStyle = FlatStyle.Flat;
            this._button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button1.Location = new System.Drawing.Point(37, 23);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(70, 65);
            this._button1.TabIndex = 0;
            // 
            // _button2
            // 
            this._button2.FlatAppearance.BorderSize = 0;
            this._button2.FlatStyle = FlatStyle.Flat;
            this._button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button2.Location = new System.Drawing.Point(108, 23);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(70, 65);
            this._button2.TabIndex = 1;
            // 
            // _button3
            // 
            this._button3.FlatAppearance.BorderSize = 0;
            this._button3.FlatStyle = FlatStyle.Flat;
            this._button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button3.Location = new System.Drawing.Point(179, 23);
            this._button3.Name = "_button3";
            this._button3.Size = new System.Drawing.Size(70, 65);
            this._button3.TabIndex = 2;
            // 
            // _button4
            // 
            this._button4.FlatAppearance.BorderSize = 0;
            this._button4.FlatStyle = FlatStyle.Flat;
            this._button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button4.Location = new System.Drawing.Point(37, 89);
            this._button4.Name = "_button4";
            this._button4.Size = new System.Drawing.Size(70, 65);
            this._button4.TabIndex = 3;
            // 
            // _button5
            // 
            this._button5.FlatAppearance.BorderSize = 0;
            this._button5.FlatStyle = FlatStyle.Flat;
            this._button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button5.Location = new System.Drawing.Point(108, 89);
            this._button5.Name = "_button5";
            this._button5.Size = new System.Drawing.Size(70, 65);
            this._button5.TabIndex = 4;
            // 
            // _button6
            // 
            this._button6.FlatAppearance.BorderSize = 0;
            this._button6.FlatStyle = FlatStyle.Flat;
            this._button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button6.Location = new System.Drawing.Point(179, 89);
            this._button6.Name = "_button6";
            this._button6.Size = new System.Drawing.Size(70, 65);
            this._button6.TabIndex = 5;
            // 
            // _button7
            // 
            this._button7.FlatAppearance.BorderSize = 0;
            this._button7.FlatStyle = FlatStyle.Flat;
            this._button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button7.Location = new System.Drawing.Point(37, 155);
            this._button7.Name = "_button7";
            this._button7.Size = new System.Drawing.Size(70, 66);
            this._button7.TabIndex = 6;
            // 
            // _button8
            // 
            this._button8.FlatAppearance.BorderSize = 0;
            this._button8.FlatStyle = FlatStyle.Flat;
            this._button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button8.Location = new System.Drawing.Point(108, 155);
            this._button8.Name = "_button8";
            this._button8.Size = new System.Drawing.Size(70, 66);
            this._button8.TabIndex = 7;
            // 
            // _button9
            // 
            this._button9.FlatAppearance.BorderSize = 0;
            this._button9.FlatStyle = FlatStyle.Flat;
            this._button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this._button9.Location = new System.Drawing.Point(179, 155);
            this._button9.Name = "_button9";
            this._button9.Size = new System.Drawing.Size(70, 66);
            this._button9.TabIndex = 8;
            // 
            // _playButton
            // 
            this._playButton.Location = new System.Drawing.Point(92, 237);
            this._playButton.Name = "_playButton";
            this._playButton.Size = new System.Drawing.Size(105, 30);
            this._playButton.TabIndex = 9;
            this._playButton.Text = "Play";
            this._playButton.Click += new System.EventHandler(this._playButton_Click);
            // 
            // eventShow
            // 
            this.eventShow.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.eventShow.Location = new System.Drawing.Point(37, 279);
            this.eventShow.Name = "eventShow";
            this.eventShow.Size = new System.Drawing.Size(212, 36);
            this.eventShow.TabIndex = 10;
            this.eventShow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(7, 17);
            this.ClientSize = new System.Drawing.Size(282, 333);
            this.Controls.Add(this.eventShow);
            this.Controls.Add(this._playButton);
            this.Controls.Add(this._button9);
            this.Controls.Add(this._button8);
            this.Controls.Add(this._button7);
            this.Controls.Add(this._button6);
            this.Controls.Add(this._button5);
            this.Controls.Add(this._button4);
            this.Controls.Add(this._button3);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._button1);
            this.MaximumSize = new System.Drawing.Size(300, 380);
            this.MinimumSize = new System.Drawing.Size(286, 360);
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private Label eventShow;
        
        #endregion
        
        private void Form1_Load(object sender, EventArgs e)
        {
            _buttonArray = new[]
                {_button1, _button2, _button3, _button4, _button5, _button6, _button7, _button8, _button9};

            for (int i = 0; i < 9; i++)
                _buttonArray[i].Click +=  ClickHandler;

            InitTicTacToe();
        }

        private void _playButton_Click(object sender, EventArgs e)
        {
            InitTicTacToe();
            eventShow.Text = "";
        }

        private void InitTicTacToe()
        {
            for (int i = 0; i < 9; i++)
            {
                _buttonArray[i].Text = "";
                _buttonArray[i].ForeColor = Color.Black;
                _buttonArray[i].BackColor = Color.LightGray;
                _buttonArray[i].Font = new Font("Microsoft Sans Serif", 24F,
                    FontStyle.Regular, GraphicsUnit.Point, 0);
            }

            _isX = true;
            _isGameOver = false;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            eventShow.Text = "";
            Button tempButton = (Button) sender;

            if (_isGameOver)
            {
                eventShow.Text = "Game Over\nClick Play for a new game!";
                return;
            }

            if (tempButton.Text != "") 
            {
                eventShow.Text = "Button already has value!";
                return;
            }

            tempButton.Text = _isX ? "X" : "O";

            _isX = !_isX;
            _isGameOver = TicTacToeUtils.CheckAndProcessWinner(_buttonArray, eventShow);
        }
    }

    public static class TicTacToeUtils
    {
        private static readonly int[,] Winners =
        {
            {0, 1, 2},
            {3, 4, 5},
            {6, 7, 8},
            {0, 3, 6},
            {1, 4, 7},
            {2, 5, 8},
            {0, 4, 8},
            {2, 4, 6}
        };
        
        public static bool CheckAndProcessWinner(Button[] myControls, Label label)
        {
            var gameOver = false;
            for (var i = 0; i < 8; i++)
            {
                int a = Winners[i, 0], b = Winners[i, 1], c = Winners[i, 2];

                Button b1 = myControls[a], b2 = myControls[b], b3 = myControls[c];

                if (b1.Text == "" || b2.Text == "" || b3.Text == "")
                    continue;

                if (b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    label.Text = "Game Over\nClick Play for a new game!";
                    b1.BackColor = b2.BackColor = b3.BackColor = Color.LightCoral;
                    b1.Font = b2.Font = b3.Font = new Font("Microsoft Sans Serif", 32F,
                        FontStyle.Italic & FontStyle.Bold,
                        GraphicsUnit.Point, 0);
                    gameOver = true;
                    break;
                }
            }

            return gameOver;
        }
    }
}