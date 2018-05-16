namespace Simplify.Grafico
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btEmail = new System.Windows.Forms.Button();
            this.btSeguradora = new System.Windows.Forms.Button();
            this.btDpvatonline = new System.Windows.Forms.Button();
            this.txtSimplify = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btConsulta = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtConsultaprocesso = new System.Windows.Forms.Label();
            this.btNovoCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAniversariantes = new System.Windows.Forms.Label();
            this.dgAniversariantes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcessosnegados = new System.Windows.Forms.Button();
            this.btProcessEnviados = new System.Windows.Forms.Button();
            this.btProcessocompendencia = new System.Windows.Forms.Button();
            this.btProcessAndamento = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btEmail);
            this.panel1.Controls.Add(this.btSeguradora);
            this.panel1.Controls.Add(this.btDpvatonline);
            this.panel1.Controls.Add(this.txtSimplify);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1803, 205);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1574, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 196);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // btEmail
            // 
            this.btEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmail.AutoSize = true;
            this.btEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Location = new System.Drawing.Point(1089, 143);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(148, 43);
            this.btEmail.TabIndex = 12;
            this.btEmail.Text = "Email";
            this.btEmail.UseVisualStyleBackColor = true;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btSeguradora
            // 
            this.btSeguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSeguradora.AutoSize = true;
            this.btSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeguradora.Location = new System.Drawing.Point(1243, 143);
            this.btSeguradora.Name = "btSeguradora";
            this.btSeguradora.Size = new System.Drawing.Size(149, 43);
            this.btSeguradora.TabIndex = 11;
            this.btSeguradora.Text = "Seguradora ";
            this.btSeguradora.UseVisualStyleBackColor = true;
            this.btSeguradora.Click += new System.EventHandler(this.btSeguradora_Click);
            // 
            // btDpvatonline
            // 
            this.btDpvatonline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDpvatonline.AutoSize = true;
            this.btDpvatonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDpvatonline.Location = new System.Drawing.Point(1409, 143);
            this.btDpvatonline.Name = "btDpvatonline";
            this.btDpvatonline.Size = new System.Drawing.Size(145, 43);
            this.btDpvatonline.TabIndex = 10;
            this.btDpvatonline.Text = "DPVAT online";
            this.btDpvatonline.UseVisualStyleBackColor = true;
            // 
            // txtSimplify
            // 
            this.txtSimplify.AutoSize = true;
            this.txtSimplify.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSimplify.Location = new System.Drawing.Point(45, 78);
            this.txtSimplify.Name = "txtSimplify";
            this.txtSimplify.Size = new System.Drawing.Size(208, 58);
            this.txtSimplify.TabIndex = 0;
            this.txtSimplify.Text = "Simplify";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.btConsulta);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.txtConsultaprocesso);
            this.panel2.Controls.Add(this.btNovoCadastro);
            this.panel2.Location = new System.Drawing.Point(1, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 243);
            this.panel2.TabIndex = 5;
            // 
            // btConsulta
            // 
            this.btConsulta.Location = new System.Drawing.Point(305, 176);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(90, 23);
            this.btConsulta.TabIndex = 3;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsultaprocesso
            // 
            this.txtConsultaprocesso.AutoSize = true;
            this.txtConsultaprocesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaprocesso.Location = new System.Drawing.Point(132, 119);
            this.txtConsultaprocesso.Name = "txtConsultaprocesso";
            this.txtConsultaprocesso.Size = new System.Drawing.Size(202, 26);
            this.txtConsultaprocesso.TabIndex = 1;
            this.txtConsultaprocesso.Text = "Consultar Processo";
            // 
            // btNovoCadastro
            // 
            this.btNovoCadastro.BackColor = System.Drawing.Color.White;
            this.btNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCadastro.Location = new System.Drawing.Point(55, 29);
            this.btNovoCadastro.Name = "btNovoCadastro";
            this.btNovoCadastro.Size = new System.Drawing.Size(340, 57);
            this.btNovoCadastro.TabIndex = 0;
            this.btNovoCadastro.Text = "Novo Cadastro";
            this.btNovoCadastro.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel3.Controls.Add(this.lbAniversariantes);
            this.panel3.Controls.Add(this.dgAniversariantes);
            this.panel3.Location = new System.Drawing.Point(1, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(460, 317);
            this.panel3.TabIndex = 6;
            // 
            // lbAniversariantes
            // 
            this.lbAniversariantes.AutoSize = true;
            this.lbAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAniversariantes.Location = new System.Drawing.Point(12, 9);
            this.lbAniversariantes.Name = "lbAniversariantes";
            this.lbAniversariantes.Size = new System.Drawing.Size(147, 25);
            this.lbAniversariantes.TabIndex = 1;
            this.lbAniversariantes.Text = "Aniversariantes";
            this.lbAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAniversariantes
            // 
            this.dgAniversariantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAniversariantes.Location = new System.Drawing.Point(3, 42);
            this.dgAniversariantes.Name = "dgAniversariantes";
            this.dgAniversariantes.RowTemplate.Height = 24;
            this.dgAniversariantes.Size = new System.Drawing.Size(454, 272);
            this.dgAniversariantes.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btProcessosnegados);
            this.panel4.Controls.Add(this.btProcessEnviados);
            this.panel4.Controls.Add(this.btProcessocompendencia);
            this.panel4.Controls.Add(this.btProcessAndamento);
            this.panel4.Location = new System.Drawing.Point(467, 208);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 566);
            this.panel4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btProcessosnegados
            // 
            this.btProcessosnegados.BackColor = System.Drawing.Color.Red;
            this.btProcessosnegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessosnegados.Location = new System.Drawing.Point(58, 420);
            this.btProcessosnegados.Name = "btProcessosnegados";
            this.btProcessosnegados.Size = new System.Drawing.Size(317, 116);
            this.btProcessosnegados.TabIndex = 3;
            this.btProcessosnegados.Text = "Processos Negados";
            this.btProcessosnegados.UseVisualStyleBackColor = false;
            // 
            // btProcessEnviados
            // 
            this.btProcessEnviados.BackColor = System.Drawing.Color.Lime;
            this.btProcessEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessEnviados.Location = new System.Drawing.Point(58, 176);
            this.btProcessEnviados.Name = "btProcessEnviados";
            this.btProcessEnviados.Size = new System.Drawing.Size(317, 116);
            this.btProcessEnviados.TabIndex = 1;
            this.btProcessEnviados.Text = "Processos enviados";
            this.btProcessEnviados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btProcessEnviados.UseVisualStyleBackColor = false;
            // 
            // btProcessocompendencia
            // 
            this.btProcessocompendencia.BackColor = System.Drawing.Color.Yellow;
            this.btProcessocompendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessocompendencia.Location = new System.Drawing.Point(58, 298);
            this.btProcessocompendencia.Name = "btProcessocompendencia";
            this.btProcessocompendencia.Size = new System.Drawing.Size(317, 116);
            this.btProcessocompendencia.TabIndex = 2;
            this.btProcessocompendencia.Text = "Processos com pendência";
            this.btProcessocompendencia.UseVisualStyleBackColor = false;
            // 
            // btProcessAndamento
            // 
            this.btProcessAndamento.AutoSize = true;
            this.btProcessAndamento.BackColor = System.Drawing.Color.Blue;
            this.btProcessAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessAndamento.Location = new System.Drawing.Point(58, 54);
            this.btProcessAndamento.Name = "btProcessAndamento";
            this.btProcessAndamento.Size = new System.Drawing.Size(317, 116);
            this.btProcessAndamento.TabIndex = 0;
            this.btProcessAndamento.Text = "Processos em andamento";
            this.btProcessAndamento.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel5.Location = new System.Drawing.Point(913, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(856, 566);
            this.panel5.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(186, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1771, 786);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btEmail;
        private System.Windows.Forms.Button btSeguradora;
        private System.Windows.Forms.Button btDpvatonline;
        private System.Windows.Forms.Label txtSimplify;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtConsultaprocesso;
        private System.Windows.Forms.Button btNovoCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgAniversariantes;
        private System.Windows.Forms.Label lbAniversariantes;
        private System.Windows.Forms.Button btProcessosnegados;
        private System.Windows.Forms.Button btProcessEnviados;
        private System.Windows.Forms.Button btProcessocompendencia;
        private System.Windows.Forms.Button btProcessAndamento;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}



