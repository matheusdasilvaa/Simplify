namespace Simplify.Grafico
{
    partial class TelaRelatorio
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
            this.pnRelatorioGerado = new System.Windows.Forms.Panel();
            this.pnRelatorioOpcoes = new System.Windows.Forms.Panel();
            this.cbStatusRelatorio = new System.Windows.Forms.ComboBox();
            this.cbDataInicioRelatorio = new System.Windows.Forms.ComboBox();
            this.cbDataFimRelatorio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.btSalvarRelatorio = new System.Windows.Forms.Button();
            this.pnRelatorioOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnRelatorioGerado
            // 
            this.pnRelatorioGerado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnRelatorioGerado.BackColor = System.Drawing.Color.Gainsboro;
            this.pnRelatorioGerado.Location = new System.Drawing.Point(276, 4);
            this.pnRelatorioGerado.Name = "pnRelatorioGerado";
            this.pnRelatorioGerado.Size = new System.Drawing.Size(305, 455);
            this.pnRelatorioGerado.TabIndex = 0;
            // 
            // pnRelatorioOpcoes
            // 
            this.pnRelatorioOpcoes.BackColor = System.Drawing.Color.Gainsboro;
            this.pnRelatorioOpcoes.Controls.Add(this.label5);
            this.pnRelatorioOpcoes.Controls.Add(this.btSalvarRelatorio);
            this.pnRelatorioOpcoes.Controls.Add(this.btGerarRelatorio);
            this.pnRelatorioOpcoes.Controls.Add(this.label3);
            this.pnRelatorioOpcoes.Controls.Add(this.label2);
            this.pnRelatorioOpcoes.Controls.Add(this.label1);
            this.pnRelatorioOpcoes.Controls.Add(this.cbDataFimRelatorio);
            this.pnRelatorioOpcoes.Controls.Add(this.cbDataInicioRelatorio);
            this.pnRelatorioOpcoes.Controls.Add(this.cbStatusRelatorio);
            this.pnRelatorioOpcoes.Location = new System.Drawing.Point(3, 4);
            this.pnRelatorioOpcoes.Name = "pnRelatorioOpcoes";
            this.pnRelatorioOpcoes.Size = new System.Drawing.Size(271, 455);
            this.pnRelatorioOpcoes.TabIndex = 1;
            // 
            // cbStatusRelatorio
            // 
            this.cbStatusRelatorio.FormattingEnabled = true;
            this.cbStatusRelatorio.Location = new System.Drawing.Point(112, 97);
            this.cbStatusRelatorio.Name = "cbStatusRelatorio";
            this.cbStatusRelatorio.Size = new System.Drawing.Size(138, 21);
            this.cbStatusRelatorio.TabIndex = 0;
            // 
            // cbDataInicioRelatorio
            // 
            this.cbDataInicioRelatorio.FormattingEnabled = true;
            this.cbDataInicioRelatorio.Location = new System.Drawing.Point(111, 177);
            this.cbDataInicioRelatorio.Name = "cbDataInicioRelatorio";
            this.cbDataInicioRelatorio.Size = new System.Drawing.Size(138, 21);
            this.cbDataInicioRelatorio.TabIndex = 1;
            this.cbDataInicioRelatorio.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbDataFimRelatorio
            // 
            this.cbDataFimRelatorio.FormattingEnabled = true;
            this.cbDataFimRelatorio.Location = new System.Drawing.Point(111, 257);
            this.cbDataFimRelatorio.Name = "cbDataFimRelatorio";
            this.cbDataFimRelatorio.Size = new System.Drawing.Size(138, 21);
            this.cbDataFimRelatorio.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Status do processo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data Inicial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Final:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Relatório de atividades";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Location = new System.Drawing.Point(94, 351);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btGerarRelatorio.TabIndex = 6;
            this.btGerarRelatorio.Text = "Gerar ";
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            // 
            // btSalvarRelatorio
            // 
            this.btSalvarRelatorio.Location = new System.Drawing.Point(175, 351);
            this.btSalvarRelatorio.Name = "btSalvarRelatorio";
            this.btSalvarRelatorio.Size = new System.Drawing.Size(75, 23);
            this.btSalvarRelatorio.TabIndex = 7;
            this.btSalvarRelatorio.Text = "Salvar";
            this.btSalvarRelatorio.UseVisualStyleBackColor = true;
            // 
            // TelaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(583, 462);
            this.Controls.Add(this.pnRelatorioOpcoes);
            this.Controls.Add(this.pnRelatorioGerado);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRelatorio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Relatorio";
            this.pnRelatorioOpcoes.ResumeLayout(false);
            this.pnRelatorioOpcoes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnRelatorioGerado;
        private System.Windows.Forms.Panel pnRelatorioOpcoes;
        private System.Windows.Forms.ComboBox cbDataFimRelatorio;
        private System.Windows.Forms.ComboBox cbDataInicioRelatorio;
        private System.Windows.Forms.ComboBox cbStatusRelatorio;
        private System.Windows.Forms.Button btSalvarRelatorio;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}