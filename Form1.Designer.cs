
namespace Media_Player_cs
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
            this.components = new System.ComponentModel.Container();
            this.Back_Button = new System.Windows.Forms.Button();
            this.Next_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Play_Button = new System.Windows.Forms.Button();
            this.Music_label = new System.Windows.Forms.Label();
            this.Current_Music_Label = new System.Windows.Forms.Label();
            this.Baixar_Som_Button = new System.Windows.Forms.Button();
            this.Update_Name = new System.Windows.Forms.Timer(this.components);
            this.Tabela_Musicas = new System.Windows.Forms.DataGridView();
            this.Column_Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name_Music = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Choose_Music_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Musicas)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.BackColor = System.Drawing.Color.Yellow;
            this.Back_Button.Location = new System.Drawing.Point(18, 64);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(67, 62);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Go Back";
            this.Back_Button.UseVisualStyleBackColor = false;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // Next_Button
            // 
            this.Next_Button.BackColor = System.Drawing.Color.Yellow;
            this.Next_Button.Location = new System.Drawing.Point(106, 64);
            this.Next_Button.Name = "Next_Button";
            this.Next_Button.Size = new System.Drawing.Size(67, 62);
            this.Next_Button.TabIndex = 1;
            this.Next_Button.Text = "Go Next";
            this.Next_Button.UseVisualStyleBackColor = false;
            this.Next_Button.Click += new System.EventHandler(this.Next_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.BackColor = System.Drawing.Color.Yellow;
            this.Pause_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause_Button.Location = new System.Drawing.Point(196, 64);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(67, 62);
            this.Pause_Button.TabIndex = 2;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = false;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Play_Button
            // 
            this.Play_Button.BackColor = System.Drawing.Color.Yellow;
            this.Play_Button.Location = new System.Drawing.Point(18, 132);
            this.Play_Button.Name = "Play_Button";
            this.Play_Button.Size = new System.Drawing.Size(67, 62);
            this.Play_Button.TabIndex = 3;
            this.Play_Button.Text = "Play";
            this.Play_Button.UseVisualStyleBackColor = false;
            this.Play_Button.Click += new System.EventHandler(this.Play_Button_Click);
            // 
            // Music_label
            // 
            this.Music_label.AutoSize = true;
            this.Music_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Music_label.Location = new System.Drawing.Point(12, 9);
            this.Music_label.Name = "Music_label";
            this.Music_label.Size = new System.Drawing.Size(183, 31);
            this.Music_label.TabIndex = 4;
            this.Music_label.Text = "Current Music";
            // 
            // Current_Music_Label
            // 
            this.Current_Music_Label.AutoSize = true;
            this.Current_Music_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Current_Music_Label.Location = new System.Drawing.Point(201, 9);
            this.Current_Music_Label.Name = "Current_Music_Label";
            this.Current_Music_Label.Size = new System.Drawing.Size(86, 31);
            this.Current_Music_Label.TabIndex = 5;
            this.Current_Music_Label.Text = "label1";
            // 
            // Baixar_Som_Button
            // 
            this.Baixar_Som_Button.BackColor = System.Drawing.Color.Yellow;
            this.Baixar_Som_Button.Location = new System.Drawing.Point(106, 132);
            this.Baixar_Som_Button.Name = "Baixar_Som_Button";
            this.Baixar_Som_Button.Size = new System.Drawing.Size(67, 62);
            this.Baixar_Som_Button.TabIndex = 8;
            this.Baixar_Som_Button.Text = "Change Volume";
            this.Baixar_Som_Button.UseVisualStyleBackColor = false;
            this.Baixar_Som_Button.Click += new System.EventHandler(this.Baixar_Som_Button_Click);
            // 
            // Update_Name
            // 
            this.Update_Name.Tick += new System.EventHandler(this.Update_Name_Tick);
            // 
            // Tabela_Musicas
            // 
            this.Tabela_Musicas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tabela_Musicas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Index,
            this.Name_Music});
            this.Tabela_Musicas.Location = new System.Drawing.Point(280, 64);
            this.Tabela_Musicas.Name = "Tabela_Musicas";
            this.Tabela_Musicas.Size = new System.Drawing.Size(1175, 813);
            this.Tabela_Musicas.TabIndex = 9;
            // 
            // Column_Index
            // 
            this.Column_Index.HeaderText = "Index Music";
            this.Column_Index.Name = "Column_Index";
            this.Column_Index.ReadOnly = true;
            // 
            // Name_Music
            // 
            this.Name_Music.HeaderText = "Music Name";
            this.Name_Music.Name = "Name_Music";
            this.Name_Music.ReadOnly = true;
            this.Name_Music.Width = 300;
            // 
            // Choose_Music_Button
            // 
            this.Choose_Music_Button.BackColor = System.Drawing.Color.Yellow;
            this.Choose_Music_Button.Location = new System.Drawing.Point(196, 132);
            this.Choose_Music_Button.Name = "Choose_Music_Button";
            this.Choose_Music_Button.Size = new System.Drawing.Size(67, 62);
            this.Choose_Music_Button.TabIndex = 10;
            this.Choose_Music_Button.Text = "Choose Music";
            this.Choose_Music_Button.UseVisualStyleBackColor = false;
            this.Choose_Music_Button.Click += new System.EventHandler(this.Choose_Music_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Choose_Music_Button);
            this.Controls.Add(this.Tabela_Musicas);
            this.Controls.Add(this.Baixar_Som_Button);
            this.Controls.Add(this.Current_Music_Label);
            this.Controls.Add(this.Music_label);
            this.Controls.Add(this.Play_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Next_Button);
            this.Controls.Add(this.Back_Button);
            this.Name = "Form1";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabela_Musicas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button Next_Button;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Button Play_Button;
        private System.Windows.Forms.Label Music_label;
        private System.Windows.Forms.Label Current_Music_Label;
        private System.Windows.Forms.Button Baixar_Som_Button;
        private System.Windows.Forms.Timer Update_Name;
        private System.Windows.Forms.DataGridView Tabela_Musicas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name_Music;
        private System.Windows.Forms.Button Choose_Music_Button;
    }
}

