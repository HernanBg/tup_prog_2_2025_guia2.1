namespace Guia2._1Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRegistrar = new Button();
            btnListar = new Button();
            lbListar = new ListBox();
            lbRegistro = new ListBox();
            SuspendLayout();
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(399, 55);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(70, 48);
            btnRegistrar.TabIndex = 0;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(394, 195);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += BtnListar_Click;
            // 
            // lbListar
            // 
            lbListar.FormattingEnabled = true;
            lbListar.ItemHeight = 15;
            lbListar.Location = new Point(43, 166);
            lbListar.Name = "lbListar";
            lbListar.Size = new Size(248, 94);
            lbListar.TabIndex = 4;
            // 
            // lbRegistro
            // 
            lbRegistro.FormattingEnabled = true;
            lbRegistro.ItemHeight = 15;
            lbRegistro.Location = new Point(43, 23);
            lbRegistro.Name = "lbRegistro";
            lbRegistro.Size = new Size(248, 94);
            lbRegistro.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbRegistro);
            Controls.Add(lbListar);
            Controls.Add(btnListar);
            Controls.Add(btnRegistrar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        public Button btnRegistrar;
        public Button btnListar;
        public ListBox lbListar;
        private ListBox lbRegistro;
    }
}
