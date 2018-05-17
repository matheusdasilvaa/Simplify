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
            this.btEmail = new System.Windows.Forms.Button();
            this.btSeguradora = new System.Windows.Forms.Button();
            this.btDpvatonline = new System.Windows.Forms.Button();
            this.txtSimplify = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btConsulta = new System.Windows.Forms.Button();
            this.tbConsultaprocesso = new System.Windows.Forms.TextBox();
            this.txtConsultaprocesso = new System.Windows.Forms.Label();
            this.btNovoCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbAniversariantes = new System.Windows.Forms.Label();
            this.dgAniversariantes = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbProcessoAndamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btProcessosnegados = new System.Windows.Forms.Button();
            this.btProcessEnviados = new System.Windows.Forms.Button();
            this.btProcessocompendencia = new System.Windows.Forms.Button();
            this.btProcessAndamento = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbProcessosEnviados = new System.Windows.Forms.Label();
            this.lbProcessoPendencia = new System.Windows.Forms.Label();
            this.lbProcessoNegado = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btEmail);
            this.panel1.Controls.Add(this.btSeguradora);
            this.panel1.Controls.Add(this.btDpvatonline);
            this.panel1.Controls.Add(this.txtSimplify);
            this.panel1.Location = new System.Drawing.Point(1, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 181);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btEmail
            // 
            this.btEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btEmail.AutoSize = true;
            this.btEmail.BackColor = System.Drawing.Color.DarkGray;
            this.btEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmail.Location = new System.Drawing.Point(815, 108);
            this.btEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btEmail.Name = "btEmail";
            this.btEmail.Size = new System.Drawing.Size(111, 35);
            this.btEmail.TabIndex = 12;
            this.btEmail.Text = "Email";
            this.btEmail.UseVisualStyleBackColor = false;
            this.btEmail.Click += new System.EventHandler(this.btEmail_Click);
            // 
            // btSeguradora
            // 
            this.btSeguradora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btSeguradora.AutoSize = true;
            this.btSeguradora.BackColor = System.Drawing.Color.DarkGray;
            this.btSeguradora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeguradora.Location = new System.Drawing.Point(930, 108);
            this.btSeguradora.Margin = new System.Windows.Forms.Padding(2);
            this.btSeguradora.Name = "btSeguradora";
            this.btSeguradora.Size = new System.Drawing.Size(112, 35);
            this.btSeguradora.TabIndex = 11;
            this.btSeguradora.Text = "Seguradora ";
            this.btSeguradora.UseVisualStyleBackColor = false;
            this.btSeguradora.Click += new System.EventHandler(this.btSeguradora_Click);
            // 
            // btDpvatonline
            // 
            this.btDpvatonline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btDpvatonline.AutoSize = true;
            this.btDpvatonline.BackColor = System.Drawing.Color.DarkGray;
            this.btDpvatonline.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDpvatonline.Location = new System.Drawing.Point(1046, 108);
            this.btDpvatonline.Margin = new System.Windows.Forms.Padding(2);
            this.btDpvatonline.Name = "btDpvatonline";
            this.btDpvatonline.Size = new System.Drawing.Size(118, 35);
            this.btDpvatonline.TabIndex = 10;
            this.btDpvatonline.Text = "DPVAT online";
            this.btDpvatonline.UseVisualStyleBackColor = false;
            // 
            // txtSimplify
            // 
            this.txtSimplify.AutoSize = true;
            this.txtSimplify.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.txtSimplify.Location = new System.Drawing.Point(31, 97);
            this.txtSimplify.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtSimplify.Name = "txtSimplify";
            this.txtSimplify.Size = new System.Drawing.Size(319, 46);
            this.txtSimplify.TabIndex = 0;
            this.txtSimplify.Text = "Simplify DPVAT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btConsulta);
            this.panel2.Controls.Add(this.tbConsultaprocesso);
            this.panel2.Controls.Add(this.txtConsultaprocesso);
            this.panel2.Controls.Add(this.btNovoCadastro);
            this.panel2.Location = new System.Drawing.Point(1, 184);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 192);
            this.panel2.TabIndex = 5;
            // 
            // btConsulta
            // 
            this.btConsulta.BackColor = System.Drawing.Color.DarkGray;
            this.btConsulta.Location = new System.Drawing.Point(206, 136);
            this.btConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btConsulta.Name = "btConsulta";
            this.btConsulta.Size = new System.Drawing.Size(76, 31);
            this.btConsulta.TabIndex = 3;
            this.btConsulta.Text = "Consultar";
            this.btConsulta.UseVisualStyleBackColor = false;
            // 
            // tbConsultaprocesso
            // 
            this.tbConsultaprocesso.Location = new System.Drawing.Point(58, 143);
            this.tbConsultaprocesso.Margin = new System.Windows.Forms.Padding(2);
            this.tbConsultaprocesso.Name = "tbConsultaprocesso";
            this.tbConsultaprocesso.Size = new System.Drawing.Size(132, 20);
            this.tbConsultaprocesso.TabIndex = 2;
            this.tbConsultaprocesso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtConsultaprocesso
            // 
            this.txtConsultaprocesso.AutoSize = true;
            this.txtConsultaprocesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaprocesso.Location = new System.Drawing.Point(94, 104);
            this.txtConsultaprocesso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtConsultaprocesso.Name = "txtConsultaprocesso";
            this.txtConsultaprocesso.Size = new System.Drawing.Size(167, 22);
            this.txtConsultaprocesso.TabIndex = 1;
            this.txtConsultaprocesso.Text = "Consultar Processo";
            // 
            // btNovoCadastro
            // 
            this.btNovoCadastro.BackColor = System.Drawing.Color.DarkGray;
            this.btNovoCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNovoCadastro.Location = new System.Drawing.Point(58, 24);
            this.btNovoCadastro.Margin = new System.Windows.Forms.Padding(2);
            this.btNovoCadastro.Name = "btNovoCadastro";
            this.btNovoCadastro.Size = new System.Drawing.Size(224, 51);
            this.btNovoCadastro.TabIndex = 0;
            this.btNovoCadastro.Text = "Novo Cadastro";
            this.btNovoCadastro.UseVisualStyleBackColor = false;
            this.btNovoCadastro.Click += new System.EventHandler(this.btNovoCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.lbAniversariantes);
            this.panel3.Controls.Add(this.dgAniversariantes);
            this.panel3.Location = new System.Drawing.Point(1, 381);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 248);
            this.panel3.TabIndex = 6;
            // 
            // lbAniversariantes
            // 
            this.lbAniversariantes.AutoSize = true;
            this.lbAniversariantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAniversariantes.Location = new System.Drawing.Point(38, 11);
            this.lbAniversariantes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAniversariantes.Name = "lbAniversariantes";
            this.lbAniversariantes.Size = new System.Drawing.Size(204, 20);
            this.lbAniversariantes.TabIndex = 1;
            this.lbAniversariantes.Text = "Aniversariantes da Semana";
            this.lbAniversariantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgAniversariantes
            // 
            this.dgAniversariantes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgAniversariantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAniversariantes.Location = new System.Drawing.Point(2, 34);
            this.dgAniversariantes.Margin = new System.Windows.Forms.Padding(2);
            this.dgAniversariantes.Name = "dgAniversariantes";
            this.dgAniversariantes.RowTemplate.Height = 24;
            this.dgAniversariantes.Size = new System.Drawing.Size(340, 211);
            this.dgAniversariantes.TabIndex = 0;
            this.dgAniversariantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAniversariantes_CellContentClick);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.lbProcessoNegado);
            this.panel4.Controls.Add(this.lbProcessoPendencia);
            this.panel4.Controls.Add(this.lbProcessosEnviados);
            this.panel4.Controls.Add(this.lbProcessoAndamento);
            this.panel4.Controls.Add(this.btProcessAndamento);
            this.panel4.Controls.Add(this.btProcessocompendencia);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.btProcessEnviados);
            this.panel4.Controls.Add(this.btProcessosnegados);
            this.panel4.Location = new System.Drawing.Point(355, 184);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(248, 444);
            this.panel4.TabIndex = 7;
            // 
            // lbProcessoAndamento
            // 
            this.lbProcessoAndamento.AutoSize = true;
            this.lbProcessoAndamento.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoAndamento.ForeColor = System.Drawing.Color.Lime;
            this.lbProcessoAndamento.Location = new System.Drawing.Point(111, 104);
            this.lbProcessoAndamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessoAndamento.Name = "lbProcessoAndamento";
            this.lbProcessoAndamento.Size = new System.Drawing.Size(25, 25);
            this.lbProcessoAndamento.TabIndex = 5;
            this.lbProcessoAndamento.Text = "0";
            this.lbProcessoAndamento.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informativo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btProcessosnegados
            // 
            this.btProcessosnegados.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessosnegados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessosnegados.Location = new System.Drawing.Point(4, 346);
            this.btProcessosnegados.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessosnegados.Name = "btProcessosnegados";
            this.btProcessosnegados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.btProcessosnegados.Size = new System.Drawing.Size(238, 94);
            this.btProcessosnegados.TabIndex = 3;
            this.btProcessosnegados.Text = "Processos Negados";
            this.btProcessosnegados.UseVisualStyleBackColor = false;
            this.btProcessosnegados.Click += new System.EventHandler(this.btProcessosnegados_Click);
            // 
            // btProcessEnviados
            // 
            this.btProcessEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessEnviados.Location = new System.Drawing.Point(4, 148);
            this.btProcessEnviados.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessEnviados.Name = "btProcessEnviados";
            this.btProcessEnviados.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.btProcessEnviados.Size = new System.Drawing.Size(238, 94);
            this.btProcessEnviados.TabIndex = 1;
            this.btProcessEnviados.Text = "Processos enviados";
            this.btProcessEnviados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btProcessEnviados.UseVisualStyleBackColor = false;
            this.btProcessEnviados.Click += new System.EventHandler(this.btProcessEnviados_Click);
            // 
            // btProcessocompendencia
            // 
            this.btProcessocompendencia.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessocompendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessocompendencia.Location = new System.Drawing.Point(4, 247);
            this.btProcessocompendencia.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessocompendencia.Name = "btProcessocompendencia";
            this.btProcessocompendencia.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.btProcessocompendencia.Size = new System.Drawing.Size(238, 94);
            this.btProcessocompendencia.TabIndex = 2;
            this.btProcessocompendencia.Text = "Processos com pendência";
            this.btProcessocompendencia.UseVisualStyleBackColor = false;
            this.btProcessocompendencia.Click += new System.EventHandler(this.btProcessocompendencia_Click);
            // 
            // btProcessAndamento
            // 
            this.btProcessAndamento.AutoSize = true;
            this.btProcessAndamento.BackColor = System.Drawing.Color.DarkGray;
            this.btProcessAndamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcessAndamento.Location = new System.Drawing.Point(4, 50);
            this.btProcessAndamento.Margin = new System.Windows.Forms.Padding(2);
            this.btProcessAndamento.Name = "btProcessAndamento";
            this.btProcessAndamento.Padding = new System.Windows.Forms.Padding(0, 0, 0, 17);
            this.btProcessAndamento.Size = new System.Drawing.Size(238, 94);
            this.btProcessAndamento.TabIndex = 0;
            this.btProcessAndamento.Text = "Processos em andamento";
            this.btProcessAndamento.UseVisualStyleBackColor = false;
            this.btProcessAndamento.Click += new System.EventHandler(this.btProcessAndamento_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(607, 184);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(720, 444);
            this.panel5.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Resultados";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1184, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 134);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbProcessosEnviados
            // 
            this.lbProcessosEnviados.AutoSize = true;
            this.lbProcessosEnviados.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessosEnviados.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessosEnviados.ForeColor = System.Drawing.Color.Blue;
            this.lbProcessosEnviados.Location = new System.Drawing.Point(111, 204);
            this.lbProcessosEnviados.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessosEnviados.Name = "lbProcessosEnviados";
            this.lbProcessosEnviados.Size = new System.Drawing.Size(25, 25);
            this.lbProcessosEnviados.TabIndex = 6;
            this.lbProcessosEnviados.Text = "0";
            // 
            // lbProcessoPendencia
            // 
            this.lbProcessoPendencia.AutoSize = true;
            this.lbProcessoPendencia.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoPendencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoPendencia.ForeColor = System.Drawing.Color.Yellow;
            this.lbProcessoPendencia.Location = new System.Drawing.Point(111, 304);
            this.lbProcessoPendencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbProcessoPendencia.Name = "lbProcessoPendencia";
            this.lbProcessoPendencia.Size = new System.Drawing.Size(25, 25);
            this.lbProcessoPendencia.TabIndex = 7;
            this.lbProcessoPendencia.Text = "0";
            // 
            // lbProcessoNegado
            // 
            this.lbProcessoNegado.AutoSize = true;
            this.lbProcessoNegado.BackColor = System.Drawing.Color.DarkGray;
            this.lbProcessoNegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbProcessoNegado.ForeColor = System.Drawing.Color.Red;
            this.lbProcessoNegado.Location = new System.Drawing.Point(113, 404);
            this.lbProcessoNegado.Name = "lbProcessoNegado";
            this.lbProcessoNegado.Size = new System.Drawing.Size(25, 25);
            this.lbProcessoNegado.TabIndex = 8;
            this.lbProcessoNegado.Text = "0";
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1328, 639);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "TelaPrincipal";
            this.Text = "TelaPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAniversariantes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox tbConsultaprocesso;
        private System.Windows.Forms.Label txtConsultaprocesso;
        private System.Windows.Forms.Button btNovoCadastro;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgAniversariantes;
        private System.Windows.Forms.Label lbAniversariantes;
        private System.Windows.Forms.Button btProcessosnegados;
        private System.Windows.Forms.Button btProcessEnviados;
        private System.Windows.Forms.Button btProcessocompendencia;
        private System.Windows.Forms.Button btProcessAndamento;
        private System.Windows.Forms.Button btConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProcessoAndamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbProcessoNegado;
        private System.Windows.Forms.Label lbProcessoPendencia;
        private System.Windows.Forms.Label lbProcessosEnviados;
    }
}



