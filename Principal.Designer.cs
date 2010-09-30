namespace TicTacToe
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Txt1 = new System.Windows.Forms.TextBox();
            this.Txt2 = new System.Windows.Forms.TextBox();
            this.BtnStart = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocal1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocal2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOnLine = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(12, 122);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(72, 16);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Jogador 1:";
            this.Lbl1.Visible = false;
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(12, 162);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(72, 16);
            this.Lbl2.TabIndex = 1;
            this.Lbl2.Text = "Jogador 2:";
            this.Lbl2.Visible = false;
            // 
            // Txt1
            // 
            this.Txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt1.Location = new System.Drawing.Point(90, 121);
            this.Txt1.Name = "Txt1";
            this.Txt1.Size = new System.Drawing.Size(101, 22);
            this.Txt1.TabIndex = 2;
            this.Txt1.Visible = false;
            // 
            // Txt2
            // 
            this.Txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt2.Location = new System.Drawing.Point(90, 161);
            this.Txt2.Name = "Txt2";
            this.Txt2.Size = new System.Drawing.Size(101, 22);
            this.Txt2.TabIndex = 3;
            this.Txt2.Visible = false;
            // 
            // BtnStart
            // 
            this.BtnStart.Enabled = false;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.Location = new System.Drawing.Point(90, 202);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(139, 44);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Iniciar";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuArquivo,
            this.MnuSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(333, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MnuArquivo
            // 
            this.MnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLocal,
            this.MnuOnLine,
            this.MnuSair});
            this.MnuArquivo.Name = "MnuArquivo";
            this.MnuArquivo.Size = new System.Drawing.Size(56, 20);
            this.MnuArquivo.Text = "Arquivo";
            // 
            // MnuLocal
            // 
            this.MnuLocal.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLocal1,
            this.MnuLocal2});
            this.MnuLocal.Name = "MnuLocal";
            this.MnuLocal.Size = new System.Drawing.Size(176, 22);
            this.MnuLocal.Text = "Novo Jogo Local";
            // 
            // MnuLocal1
            // 
            this.MnuLocal1.Name = "MnuLocal1";
            this.MnuLocal1.Size = new System.Drawing.Size(152, 22);
            this.MnuLocal1.Text = "1 jogador";
            this.MnuLocal1.Click += new System.EventHandler(this.MnuLocal1_Click);
            // 
            // MnuLocal2
            // 
            this.MnuLocal2.Name = "MnuLocal2";
            this.MnuLocal2.Size = new System.Drawing.Size(152, 22);
            this.MnuLocal2.Text = "2 jogadores";
            this.MnuLocal2.Click += new System.EventHandler(this.MnuLocal2_Click);
            // 
            // MnuOnLine
            // 
            this.MnuOnLine.Name = "MnuOnLine";
            this.MnuOnLine.Size = new System.Drawing.Size(176, 22);
            this.MnuOnLine.Text = "Novo Jogo On-Line";
            // 
            // MnuSair
            // 
            this.MnuSair.Name = "MnuSair";
            this.MnuSair.Size = new System.Drawing.Size(176, 22);
            this.MnuSair.Text = "Sair";
            this.MnuSair.Click += new System.EventHandler(this.MnuSair_Click);
            // 
            // MnuSobre
            // 
            this.MnuSobre.Name = "MnuSobre";
            this.MnuSobre.Size = new System.Drawing.Size(47, 20);
            this.MnuSobre.Text = "Sobre";
            this.MnuSobre.Click += new System.EventHandler(this.MnuSobre_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 53);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(217, 37);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "Programa desenvolvido em 27/09/2010.\nAinda em fase de desenvolvimento";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(333, 281);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.Txt1);
            this.Controls.Add(this.Txt2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox Txt1;
        private System.Windows.Forms.TextBox Txt2;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem MnuLocal;
        private System.Windows.Forms.ToolStripMenuItem MnuLocal1;
        private System.Windows.Forms.ToolStripMenuItem MnuLocal2;
        private System.Windows.Forms.ToolStripMenuItem MnuSobre;
        private System.Windows.Forms.ToolStripMenuItem MnuOnLine;
        private System.Windows.Forms.ToolStripMenuItem MnuSair;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}