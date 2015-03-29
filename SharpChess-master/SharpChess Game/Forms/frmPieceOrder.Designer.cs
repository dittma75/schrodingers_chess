namespace SharpChess.Forms
{
    partial class frmPieceOrder
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
            this.Bishop1 = new System.Windows.Forms.PictureBox();
            this.Queen = new System.Windows.Forms.PictureBox();
            this.Knight1 = new System.Windows.Forms.PictureBox();
            this.Rook1 = new System.Windows.Forms.PictureBox();
            this.Rook2 = new System.Windows.Forms.PictureBox();
            this.Knight2 = new System.Windows.Forms.PictureBox();
            this.Bishop2 = new System.Windows.Forms.PictureBox();
            this.SelectOrder = new System.Windows.Forms.Button();
            this.numericUpDownRook2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRook1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKnight1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBishop1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBishop2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownQueen = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownKnight2 = new System.Windows.Forms.NumericUpDown();
            this.errorMessage = new System.Windows.Forms.Label();
            this.randomOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Bishop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Queen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rook2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knight2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bishop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRook2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRook1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnight1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBishop1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBishop2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnight2)).BeginInit();
            this.SuspendLayout();
            // 
            // Bishop1
            // 
            this.Bishop1.Image = global::SharpChess.Properties.Resources.Bishop_White;
            this.Bishop1.Location = new System.Drawing.Point(92, 3);
            this.Bishop1.Name = "Bishop1";
            this.Bishop1.Size = new System.Drawing.Size(44, 50);
            this.Bishop1.TabIndex = 1;
            this.Bishop1.TabStop = false;
            // 
            // Queen
            // 
            this.Queen.Image = global::SharpChess.Properties.Resources.Queen_White;
            this.Queen.Location = new System.Drawing.Point(136, 3);
            this.Queen.Name = "Queen";
            this.Queen.Size = new System.Drawing.Size(50, 50);
            this.Queen.TabIndex = 4;
            this.Queen.TabStop = false;
            // 
            // Knight1
            // 
            this.Knight1.Image = global::SharpChess.Properties.Resources.Knight_White;
            this.Knight1.Location = new System.Drawing.Point(45, 3);
            this.Knight1.Name = "Knight1";
            this.Knight1.Size = new System.Drawing.Size(45, 50);
            this.Knight1.TabIndex = 5;
            this.Knight1.TabStop = false;
            // 
            // Rook1
            // 
            this.Rook1.Image = global::SharpChess.Properties.Resources.Rook_White;
            this.Rook1.Location = new System.Drawing.Point(2, 3);
            this.Rook1.Name = "Rook1";
            this.Rook1.Size = new System.Drawing.Size(44, 50);
            this.Rook1.TabIndex = 6;
            this.Rook1.TabStop = false;
            // 
            // Rook2
            // 
            this.Rook2.Image = global::SharpChess.Properties.Resources.Rook_White;
            this.Rook2.Location = new System.Drawing.Point(280, 3);
            this.Rook2.Name = "Rook2";
            this.Rook2.Size = new System.Drawing.Size(44, 50);
            this.Rook2.TabIndex = 9;
            this.Rook2.TabStop = false;
            // 
            // Knight2
            // 
            this.Knight2.Image = global::SharpChess.Properties.Resources.Knight_White;
            this.Knight2.Location = new System.Drawing.Point(229, 3);
            this.Knight2.Name = "Knight2";
            this.Knight2.Size = new System.Drawing.Size(51, 50);
            this.Knight2.TabIndex = 8;
            this.Knight2.TabStop = false;
            // 
            // Bishop2
            // 
            this.Bishop2.Image = global::SharpChess.Properties.Resources.Bishop_White;
            this.Bishop2.Location = new System.Drawing.Point(185, 3);
            this.Bishop2.Name = "Bishop2";
            this.Bishop2.Size = new System.Drawing.Size(44, 50);
            this.Bishop2.TabIndex = 7;
            this.Bishop2.TabStop = false;
            // 
            // SelectOrder
            // 
            this.SelectOrder.Location = new System.Drawing.Point(174, 106);
            this.SelectOrder.Name = "SelectOrder";
            this.SelectOrder.Size = new System.Drawing.Size(108, 23);
            this.SelectOrder.TabIndex = 0;
            this.SelectOrder.Text = "Select Order";
            this.SelectOrder.UseVisualStyleBackColor = true;
            this.SelectOrder.Click += new System.EventHandler(this.SelectOrder_Click);
            // 
            // numericUpDownRook2
            // 
            this.numericUpDownRook2.Location = new System.Drawing.Point(287, 59);
            this.numericUpDownRook2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownRook2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRook2.Name = "numericUpDownRook2";
            this.numericUpDownRook2.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownRook2.TabIndex = 14;
            this.numericUpDownRook2.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // numericUpDownRook1
            // 
            this.numericUpDownRook1.Location = new System.Drawing.Point(9, 59);
            this.numericUpDownRook1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownRook1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRook1.Name = "numericUpDownRook1";
            this.numericUpDownRook1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownRook1.TabIndex = 15;
            this.numericUpDownRook1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDownKnight1
            // 
            this.numericUpDownKnight1.Location = new System.Drawing.Point(53, 59);
            this.numericUpDownKnight1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownKnight1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKnight1.Name = "numericUpDownKnight1";
            this.numericUpDownKnight1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownKnight1.TabIndex = 16;
            this.numericUpDownKnight1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownBishop1
            // 
            this.numericUpDownBishop1.Location = new System.Drawing.Point(99, 59);
            this.numericUpDownBishop1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownBishop1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBishop1.Name = "numericUpDownBishop1";
            this.numericUpDownBishop1.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownBishop1.TabIndex = 17;
            this.numericUpDownBishop1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDownBishop2
            // 
            this.numericUpDownBishop2.Location = new System.Drawing.Point(192, 59);
            this.numericUpDownBishop2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownBishop2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBishop2.Name = "numericUpDownBishop2";
            this.numericUpDownBishop2.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownBishop2.TabIndex = 18;
            this.numericUpDownBishop2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownQueen
            // 
            this.numericUpDownQueen.Location = new System.Drawing.Point(144, 59);
            this.numericUpDownQueen.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownQueen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQueen.Name = "numericUpDownQueen";
            this.numericUpDownQueen.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownQueen.TabIndex = 19;
            this.numericUpDownQueen.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numericUpDownKnight2
            // 
            this.numericUpDownKnight2.Location = new System.Drawing.Point(238, 59);
            this.numericUpDownKnight2.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDownKnight2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKnight2.Name = "numericUpDownKnight2";
            this.numericUpDownKnight2.Size = new System.Drawing.Size(30, 20);
            this.numericUpDownKnight2.TabIndex = 20;
            this.numericUpDownKnight2.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // errorMessage
            // 
            this.errorMessage.AutoSize = true;
            this.errorMessage.Location = new System.Drawing.Point(11, 90);
            this.errorMessage.Name = "errorMessage";
            this.errorMessage.Size = new System.Drawing.Size(182, 13);
            this.errorMessage.TabIndex = 21;
            this.errorMessage.Text = "Piece order numbers must be unique.";
            this.errorMessage.Visible = false;
            // 
            // randomOrder
            // 
            this.randomOrder.Location = new System.Drawing.Point(53, 106);
            this.randomOrder.Name = "randomOrder";
            this.randomOrder.Size = new System.Drawing.Size(104, 23);
            this.randomOrder.TabIndex = 22;
            this.randomOrder.Text = "Random Order";
            this.randomOrder.UseVisualStyleBackColor = true;
            this.randomOrder.Click += new System.EventHandler(this.randomOrder_Click);
            // 
            // frmPieceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 140);
            this.Controls.Add(this.randomOrder);
            this.Controls.Add(this.errorMessage);
            this.Controls.Add(this.numericUpDownKnight2);
            this.Controls.Add(this.numericUpDownQueen);
            this.Controls.Add(this.numericUpDownBishop2);
            this.Controls.Add(this.numericUpDownBishop1);
            this.Controls.Add(this.numericUpDownKnight1);
            this.Controls.Add(this.numericUpDownRook1);
            this.Controls.Add(this.numericUpDownRook2);
            this.Controls.Add(this.Rook2);
            this.Controls.Add(this.Knight2);
            this.Controls.Add(this.Bishop2);
            this.Controls.Add(this.Rook1);
            this.Controls.Add(this.Knight1);
            this.Controls.Add(this.Queen);
            this.Controls.Add(this.Bishop1);
            this.Controls.Add(this.SelectOrder);
            this.Name = "frmPieceOrder";
            this.Text = "Select Piece Order";
            ((System.ComponentModel.ISupportInitialize)(this.Bishop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Queen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rook2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Knight2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bishop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRook2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRook1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnight1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBishop1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBishop2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQueen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKnight2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Bishop1;
        private System.Windows.Forms.PictureBox Queen;
        private System.Windows.Forms.PictureBox Knight1;
        private System.Windows.Forms.PictureBox Rook1;
        private System.Windows.Forms.PictureBox Rook2;
        private System.Windows.Forms.PictureBox Knight2;
        private System.Windows.Forms.PictureBox Bishop2;
        private System.Windows.Forms.Button SelectOrder;
        private System.Windows.Forms.NumericUpDown numericUpDownRook2;
        private System.Windows.Forms.NumericUpDown numericUpDownRook1;
        private System.Windows.Forms.NumericUpDown numericUpDownKnight1;
        private System.Windows.Forms.NumericUpDown numericUpDownBishop1;
        private System.Windows.Forms.NumericUpDown numericUpDownBishop2;
        private System.Windows.Forms.NumericUpDown numericUpDownQueen;
        private System.Windows.Forms.NumericUpDown numericUpDownKnight2;
        private System.Windows.Forms.Label errorMessage;
        private System.Windows.Forms.Button randomOrder;
    }
}