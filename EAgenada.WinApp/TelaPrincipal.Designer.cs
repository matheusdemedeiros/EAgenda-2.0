namespace EAgenda.WinApp
{
    partial class TelaPrincipal
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
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnContatos = new System.Windows.Forms.Button();
            this.btnCompromisso = new System.Windows.Forms.Button();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(24, 28);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(152, 57);
            this.btnTarefas.TabIndex = 0;
            this.btnTarefas.Text = "Gerenciamento de Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnContatos
            // 
            this.btnContatos.Location = new System.Drawing.Point(24, 172);
            this.btnContatos.Name = "btnContatos";
            this.btnContatos.Size = new System.Drawing.Size(152, 53);
            this.btnContatos.TabIndex = 1;
            this.btnContatos.Text = "Gerenciamento de Contatos";
            this.btnContatos.UseVisualStyleBackColor = true;
            this.btnContatos.Click += new System.EventHandler(this.btnContatos_Click);
            // 
            // btnCompromisso
            // 
            this.btnCompromisso.Location = new System.Drawing.Point(24, 101);
            this.btnCompromisso.Name = "btnCompromisso";
            this.btnCompromisso.Size = new System.Drawing.Size(152, 55);
            this.btnCompromisso.TabIndex = 2;
            this.btnCompromisso.Text = "Gerenciamento de compromisso";
            this.btnCompromisso.UseVisualStyleBackColor = true;
            this.btnCompromisso.Click += new System.EventHandler(this.btnCompromisso_Click);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.SlateBlue;
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.Location = new System.Drawing.Point(199, 101);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(687, 346);
            this.panelPrincipal.TabIndex = 3;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(898, 459);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnCompromisso);
            this.Controls.Add(this.btnContatos);
            this.Controls.Add(this.btnTarefas);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.Text = "e-Agenda 2.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnContatos;
        private System.Windows.Forms.Button btnCompromisso;
        private System.Windows.Forms.Panel panelPrincipal;
    }
}
