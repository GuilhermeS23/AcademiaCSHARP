namespace WinFormsApp2
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
            cadastrarPessoa = new Button();
            gerarAmigoSecreto = new Button();
            SuspendLayout();
            // 
            // cadastrarPessoa
            // 
            cadastrarPessoa.Location = new Point(211, 83);
            cadastrarPessoa.Name = "cadastrarPessoa";
            cadastrarPessoa.Size = new Size(75, 23);
            cadastrarPessoa.TabIndex = 0;
            cadastrarPessoa.Text = "Adicionar";
            cadastrarPessoa.UseVisualStyleBackColor = true;
            cadastrarPessoa.Click += cadastrarPessoa_Click;
            // 
            // gerarAmigoSecreto
            // 
            gerarAmigoSecreto.Location = new Point(487, 83);
            gerarAmigoSecreto.Name = "gerarAmigoSecreto";
            gerarAmigoSecreto.Size = new Size(75, 23);
            gerarAmigoSecreto.TabIndex = 1;
            gerarAmigoSecreto.Text = "Gerar Duplas";
            gerarAmigoSecreto.UseVisualStyleBackColor = true;
            gerarAmigoSecreto.Click += gerarAmigoSecreto_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gerarAmigoSecreto);
            Controls.Add(cadastrarPessoa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button cadastrarPessoa;
        private Button gerarAmigoSecreto;
    }
}