
namespace formsqlbaglantıproje
{
    partial class formsqlproje
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
            this.yzradilabel = new System.Windows.Forms.Label();
            this.yzrsoyadilabel = new System.Windows.Forms.Label();
            this.yzraditextbox = new System.Windows.Forms.TextBox();
            this.yzrsyditextbox = new System.Windows.Forms.TextBox();
            this.verigtrbutton = new System.Windows.Forms.Button();
            this.kydtbutton = new System.Windows.Forms.Button();
            this.silbutton = new System.Windows.Forms.Button();
            this.güncellebutton = new System.Windows.Forms.Button();
            this.cikisbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.yzrNoTextboX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yzradilabel
            // 
            this.yzradilabel.AutoSize = true;
            this.yzradilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yzradilabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yzradilabel.Location = new System.Drawing.Point(151, 59);
            this.yzradilabel.Name = "yzradilabel";
            this.yzradilabel.Size = new System.Drawing.Size(134, 18);
            this.yzradilabel.TabIndex = 10;
            this.yzradilabel.Text = "Yazar Adı          :";
            // 
            // yzrsoyadilabel
            // 
            this.yzrsoyadilabel.AutoSize = true;
            this.yzrsoyadilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yzrsoyadilabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.yzrsoyadilabel.Location = new System.Drawing.Point(151, 97);
            this.yzrsoyadilabel.Name = "yzrsoyadilabel";
            this.yzrsoyadilabel.Size = new System.Drawing.Size(132, 18);
            this.yzrsoyadilabel.TabIndex = 11;
            this.yzrsoyadilabel.Text = "Yazar Soyadı    :";
            // 
            // yzraditextbox
            // 
            this.yzraditextbox.Location = new System.Drawing.Point(317, 53);
            this.yzraditextbox.Name = "yzraditextbox";
            this.yzraditextbox.Size = new System.Drawing.Size(223, 24);
            this.yzraditextbox.TabIndex = 2;
            // 
            // yzrsyditextbox
            // 
            this.yzrsyditextbox.Location = new System.Drawing.Point(317, 94);
            this.yzrsyditextbox.Name = "yzrsyditextbox";
            this.yzrsyditextbox.Size = new System.Drawing.Size(223, 24);
            this.yzrsyditextbox.TabIndex = 3;
            // 
            // verigtrbutton
            // 
            this.verigtrbutton.BackColor = System.Drawing.Color.Blue;
            this.verigtrbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.verigtrbutton.Location = new System.Drawing.Point(152, 236);
            this.verigtrbutton.Name = "verigtrbutton";
            this.verigtrbutton.Size = new System.Drawing.Size(388, 33);
            this.verigtrbutton.TabIndex = 6;
            this.verigtrbutton.Text = "Listele";
            this.verigtrbutton.UseVisualStyleBackColor = false;
            this.verigtrbutton.Click += new System.EventHandler(this.verigtrbutton_Click);
            // 
            // kydtbutton
            // 
            this.kydtbutton.BackColor = System.Drawing.Color.Lime;
            this.kydtbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kydtbutton.Location = new System.Drawing.Point(152, 142);
            this.kydtbutton.Name = "kydtbutton";
            this.kydtbutton.Size = new System.Drawing.Size(388, 33);
            this.kydtbutton.TabIndex = 4;
            this.kydtbutton.Text = "Kaydet";
            this.kydtbutton.UseVisualStyleBackColor = false;
            this.kydtbutton.Click += new System.EventHandler(this.kydtbutton_Click);
            // 
            // silbutton
            // 
            this.silbutton.BackColor = System.Drawing.Color.Red;
            this.silbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbutton.Location = new System.Drawing.Point(152, 283);
            this.silbutton.Name = "silbutton";
            this.silbutton.Size = new System.Drawing.Size(388, 33);
            this.silbutton.TabIndex = 7;
            this.silbutton.Text = "Sil";
            this.silbutton.UseVisualStyleBackColor = false;
            this.silbutton.Click += new System.EventHandler(this.silbutton_Click);
            // 
            // güncellebutton
            // 
            this.güncellebutton.BackColor = System.Drawing.Color.PeachPuff;
            this.güncellebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.güncellebutton.Location = new System.Drawing.Point(154, 189);
            this.güncellebutton.Name = "güncellebutton";
            this.güncellebutton.Size = new System.Drawing.Size(386, 33);
            this.güncellebutton.TabIndex = 5;
            this.güncellebutton.Text = "Güncelle";
            this.güncellebutton.UseVisualStyleBackColor = false;
            this.güncellebutton.Click += new System.EventHandler(this.güncellebutton_Click);
            // 
            // cikisbutton
            // 
            this.cikisbutton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cikisbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikisbutton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.cikisbutton.Location = new System.Drawing.Point(152, 330);
            this.cikisbutton.Name = "cikisbutton";
            this.cikisbutton.Size = new System.Drawing.Size(390, 33);
            this.cikisbutton.TabIndex = 8;
            this.cikisbutton.Text = "Çıkış";
            this.cikisbutton.UseVisualStyleBackColor = false;
            this.cikisbutton.Click += new System.EventHandler(this.cikisbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 370);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(649, 112);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // yzrNoTextboX
            // 
            this.yzrNoTextboX.Location = new System.Drawing.Point(317, 20);
            this.yzrNoTextboX.Name = "yzrNoTextboX";
            this.yzrNoTextboX.ReadOnly = true;
            this.yzrNoTextboX.Size = new System.Drawing.Size(223, 24);
            this.yzrNoTextboX.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(149, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yazar No          :";
            // 
            // formsqlproje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(671, 511);
            this.Controls.Add(this.yzrNoTextboX);
            this.Controls.Add(this.verigtrbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cikisbutton);
            this.Controls.Add(this.güncellebutton);
            this.Controls.Add(this.silbutton);
            this.Controls.Add(this.kydtbutton);
            this.Controls.Add(this.yzrsyditextbox);
            this.Controls.Add(this.yzraditextbox);
            this.Controls.Add(this.yzrsoyadilabel);
            this.Controls.Add(this.yzradilabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "formsqlproje";
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label yzradilabel;
        private System.Windows.Forms.Label yzrsoyadilabel;
        private System.Windows.Forms.TextBox yzraditextbox;
        private System.Windows.Forms.TextBox yzrsyditextbox;
        private System.Windows.Forms.Button verigtrbutton;
        private System.Windows.Forms.Button kydtbutton;
        private System.Windows.Forms.Button silbutton;
        private System.Windows.Forms.Button güncellebutton;
        private System.Windows.Forms.Button cikisbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox yzrNoTextboX;
        private System.Windows.Forms.Label label1;
    }
}

