namespace bonustask3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb = new PictureBox();
            lb = new ListBox();
            btnAdd = new Button();
            btnTurn = new Button();
            btnMove = new Button();
            btnScale = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // pb
            // 
            pb.BackColor = SystemColors.ButtonHighlight;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Location = new System.Drawing.Point(27, 19);
            pb.Name = "pb";
            pb.Size = new Size(378, 404);
            pb.TabIndex = 0;
            pb.TabStop = false;
            // 
            // lb
            // 
            lb.BackColor = SystemColors.InactiveBorder;
            lb.FormattingEnabled = true;
            lb.Location = new System.Drawing.Point(423, 19);
            lb.Name = "lb";
            lb.Size = new Size(345, 109);
            lb.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(534, 151);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 73);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Добавить фигуры";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnTurn
            // 
            btnTurn.Location = new System.Drawing.Point(667, 241);
            btnTurn.Name = "btnTurn";
            btnTurn.Size = new Size(121, 56);
            btnTurn.TabIndex = 3;
            btnTurn.Text = "Повернуть [0]";
            btnTurn.UseVisualStyleBackColor = true;
            // 
            // btnMove
            // 
            btnMove.Location = new System.Drawing.Point(423, 241);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(119, 56);
            btnMove.TabIndex = 4;
            btnMove.Text = "Сдвинуть [0]";
            btnMove.UseVisualStyleBackColor = true;
            // 
            // btnScale
            // 
            btnScale.Location = new System.Drawing.Point(548, 241);
            btnScale.Name = "btnScale";
            btnScale.Size = new Size(113, 56);
            btnScale.TabIndex = 5;
            btnScale.Text = "Масштаб [1]";
            btnScale.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(534, 318);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 68);
            btnClear.TabIndex = 6;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnScale);
            Controls.Add(btnMove);
            Controls.Add(btnTurn);
            Controls.Add(btnAdd);
            Controls.Add(lb);
            Controls.Add(pb);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb;
        private ListBox lb;
        private Button btnAdd;
        private Button btnTurn;
        private Button btnMove;
        private Button btnScale;
        private Button btnClear;
    }
}