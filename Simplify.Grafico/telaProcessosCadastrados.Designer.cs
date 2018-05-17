namespace Simplify.Grafico
{
    partial class TelaProcessosCadastrados
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
            this.dgProcessosCadastrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProcessosCadastrados
            // 
            this.dgProcessosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProcessosCadastrados.Location = new System.Drawing.Point(12, 12);
            this.dgProcessosCadastrados.Name = "dgProcessosCadastrados";
            this.dgProcessosCadastrados.RowTemplate.Height = 24;
            this.dgProcessosCadastrados.Size = new System.Drawing.Size(453, 510);
            this.dgProcessosCadastrados.TabIndex = 0;
            // 
            // TelaProcessosCadastrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 534);
            this.Controls.Add(this.dgProcessosCadastrados);
            this.Name = "TelaProcessosCadastrados";
            this.Text = "Processos Cadastrados";
            ((System.ComponentModel.ISupportInitialize)(this.dgProcessosCadastrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProcessosCadastrados;
    }
}