namespace Crucigrama
{
    partial class Menu
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
            label1 = new Label();
            btn_config = new Button();
            btn_partida = new Button();
            btn_tabla = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Emoji", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(168, 39);
            label1.Name = "label1";
            label1.Size = new Size(65, 26);
            label1.TabIndex = 0;
            label1.Text = "Menu";
            // 
            // btn_config
            // 
            btn_config.BackColor = Color.FromArgb(6, 57, 112);
            btn_config.FlatStyle = FlatStyle.Flat;
            btn_config.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_config.ForeColor = Color.White;
            btn_config.Location = new Point(124, 85);
            btn_config.Name = "btn_config";
            btn_config.Size = new Size(153, 31);
            btn_config.TabIndex = 1;
            btn_config.Text = "Configuracion";
            btn_config.UseVisualStyleBackColor = false;
            btn_config.Click += btn_config_Click;
            // 
            // btn_partida
            // 
            btn_partida.BackColor = Color.FromArgb(6, 57, 112);
            btn_partida.FlatStyle = FlatStyle.Flat;
            btn_partida.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_partida.ForeColor = Color.White;
            btn_partida.Location = new Point(124, 136);
            btn_partida.Name = "btn_partida";
            btn_partida.Size = new Size(153, 31);
            btn_partida.TabIndex = 2;
            btn_partida.Text = "Jugar Partida";
            btn_partida.UseVisualStyleBackColor = false;
            btn_partida.Click += btn_partida_Click;
            // 
            // btn_tabla
            // 
            btn_tabla.BackColor = Color.FromArgb(6, 57, 112);
            btn_tabla.FlatStyle = FlatStyle.Flat;
            btn_tabla.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tabla.ForeColor = Color.White;
            btn_tabla.Location = new Point(124, 185);
            btn_tabla.Name = "btn_tabla";
            btn_tabla.Size = new Size(153, 31);
            btn_tabla.TabIndex = 3;
            btn_tabla.Text = "Tabla de Resultados";
            btn_tabla.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 279);
            Controls.Add(btn_tabla);
            Controls.Add(btn_partida);
            Controls.Add(btn_config);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_config;
        private Button btn_partida;
        private Button btn_tabla;
    }
}