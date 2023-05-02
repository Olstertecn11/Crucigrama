namespace Crucigrama
{
    partial class Configuracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuracion));
            pic_1 = new PictureBox();
            pic_2 = new PictureBox();
            txt_j1 = new TextBox();
            txt_j2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_guardar = new Button();
            btn_pic_1 = new Button();
            btn_pic_2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pic_1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_2).BeginInit();
            SuspendLayout();
            // 
            // pic_1
            // 
            pic_1.BackColor = SystemColors.ControlLight;
            pic_1.Location = new Point(62, 116);
            pic_1.Name = "pic_1";
            pic_1.Size = new Size(212, 167);
            pic_1.SizeMode = PictureBoxSizeMode.Zoom;
            pic_1.TabIndex = 0;
            pic_1.TabStop = false;
            // 
            // pic_2
            // 
            pic_2.BackColor = SystemColors.ControlLight;
            pic_2.Location = new Point(519, 116);
            pic_2.Name = "pic_2";
            pic_2.Size = new Size(214, 167);
            pic_2.SizeMode = PictureBoxSizeMode.Zoom;
            pic_2.TabIndex = 1;
            pic_2.TabStop = false;
            // 
            // txt_j1
            // 
            txt_j1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_j1.Location = new Point(62, 71);
            txt_j1.Multiline = true;
            txt_j1.Name = "txt_j1";
            txt_j1.Size = new Size(176, 32);
            txt_j1.TabIndex = 2;
            // 
            // txt_j2
            // 
            txt_j2.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txt_j2.Location = new Point(519, 71);
            txt_j2.Multiline = true;
            txt_j2.Name = "txt_j2";
            txt_j2.Size = new Size(178, 32);
            txt_j2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 29);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 4;
            label1.Text = "Jugador #1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(519, 29);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 5;
            label2.Text = "Jugador #2";
            // 
            // btn_guardar
            // 
            btn_guardar.BackColor = Color.SeaGreen;
            btn_guardar.FlatStyle = FlatStyle.Flat;
            btn_guardar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_guardar.ForeColor = Color.White;
            btn_guardar.Location = new Point(62, 308);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(136, 30);
            btn_guardar.TabIndex = 6;
            btn_guardar.Text = "Guardar Cambios";
            btn_guardar.UseVisualStyleBackColor = false;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // btn_pic_1
            // 
            btn_pic_1.Image = (Image)resources.GetObject("btn_pic_1.Image");
            btn_pic_1.Location = new Point(244, 71);
            btn_pic_1.Name = "btn_pic_1";
            btn_pic_1.Size = new Size(30, 32);
            btn_pic_1.TabIndex = 7;
            btn_pic_1.UseVisualStyleBackColor = true;
            btn_pic_1.Click += btn_pic_1_Click;
            // 
            // btn_pic_2
            // 
            btn_pic_2.Image = (Image)resources.GetObject("btn_pic_2.Image");
            btn_pic_2.Location = new Point(703, 71);
            btn_pic_2.Name = "btn_pic_2";
            btn_pic_2.Size = new Size(30, 35);
            btn_pic_2.TabIndex = 8;
            btn_pic_2.UseVisualStyleBackColor = true;
            btn_pic_2.Click += btn_pic_2_Click;
            // 
            // Configuracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 363);
            Controls.Add(btn_pic_2);
            Controls.Add(btn_pic_1);
            Controls.Add(btn_guardar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_j2);
            Controls.Add(txt_j1);
            Controls.Add(pic_2);
            Controls.Add(pic_1);
            Name = "Configuracion";
            Text = "Configuracion";
            ((System.ComponentModel.ISupportInitialize)pic_1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pic_1;
        private PictureBox pic_2;
        private TextBox txt_j1;
        private TextBox txt_j2;
        private Label label1;
        private Label label2;
        private Button btn_guardar;
        private Button btn_pic_1;
        private Button btn_pic_2;
    }
}