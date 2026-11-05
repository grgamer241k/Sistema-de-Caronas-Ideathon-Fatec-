namespace Prototipo_Caronas_Fatec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            btn_passageiro = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(78, 178);
            label1.Name = "label1";
            label1.Size = new Size(178, 21);
            label1.TabIndex = 0;
            label1.Text = "Como Você quer usar?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.AppWorkspace;
            label2.Location = new Point(54, 208);
            label2.Name = "label2";
            label2.Size = new Size(236, 20);
            label2.TabIndex = 1;
            label2.Text = "Escolha uma opção para começar:";
            // 
            // btn_passageiro
            // 
            btn_passageiro.BackColor = Color.FromArgb(200, 209, 217);
            btn_passageiro.FlatAppearance.BorderColor = Color.White;
            btn_passageiro.FlatStyle = FlatStyle.Popup;
            btn_passageiro.Font = new Font("Segoe UI", 18F);
            btn_passageiro.Location = new Point(54, 266);
            btn_passageiro.Name = "btn_passageiro";
            btn_passageiro.Size = new Size(236, 85);
            btn_passageiro.TabIndex = 2;
            btn_passageiro.Text = "Sou passageiro";
            btn_passageiro.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(350, 591);
            Controls.Add(btn_passageiro);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btn_passageiro;
    }
}
